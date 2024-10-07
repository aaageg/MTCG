using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MTCG
{
    internal class Program
    {
        static List<User> users = new List<User>();

        static async Task Main(string[] args)
        {
            MagicCard fireball = new MagicCard("Fireball", "Fire", 10, "Shoot fireballs");
            //fireball.Display();//show card

            //Console.WriteLine(); 

            
            MonsterCard dragon = new MonsterCard("Red Dragon", "Fire", 20, "Dragon");
            //dragon.Display();

            User u1 = new User();
            u1.Name = "Test01";
            u1.Email = "123@123";
            u1.Password = "123456";
            u1.Gold = "20";
            u1.Token = "54321";
            //u1.display();
            users.Add(u1);
            
            HttpListener listener = new HttpListener();
            listener.Prefixes.Add("http://+:8000/"); 
            listener.Start();
            //Console.WriteLine("HTTP 服务器已启动，正在监听端口 8000");
            Console.WriteLine("HTTP server started, listening on port 8000");

            
            await AcceptClientsAsync(listener);

            //Console.WriteLine("按任意键退出服务器...");
            Console.WriteLine("Press any key to exit the server...");
            Console.ReadKey();
            listener.Stop();
        }

        static async Task AcceptClientsAsync(HttpListener listener)
        {
            while (true)
            {
                
                HttpListenerContext context = await listener.GetContextAsync();
                //Console.WriteLine("收到 HTTP 请求。");
                Console.WriteLine("An HTTP request is received.");

                Task.Run(() => HandleClientAsync(context));
            }
        }

        static async Task HandleClientAsync(HttpListenerContext context)
        {
            HttpListenerRequest request = context.Request;
            HttpListenerResponse response = context.Response;

            // Read request information
            string method = request.HttpMethod;
            string url = request.Url.AbsolutePath;
            //Console.WriteLine($"请求方法：{method}, 请求 URL：{url}");
            Console.WriteLine($"Request method：{method}, Request URL：{url}");

            
            string requestBody = null;
            if (request.HasEntityBody)
            {
                using (var reader = new System.IO.StreamReader(request.InputStream, request.ContentEncoding))
                {
                    requestBody = await reader.ReadToEndAsync();
                }
                //Console.WriteLine($"请求正文：{requestBody}");
                Console.WriteLine($"Request body：{requestBody}");
            }

            string responseString = "";

            try
            {
                if (method == "POST" && url == "/login")
                {
                    // Parse the request body into a UserRequest object
                    User userRequest = JsonConvert.DeserializeObject<User>(requestBody);

                    
                    string email = userRequest.Email;
                    string password = userRequest.Password;
                    User findUser = users.Find(u => u.Email == email && u.Password == password);
                    if (findUser != null)
                    {
                        // Update the token for the found user
                        findUser.Token = Guid.NewGuid().ToString(); // Generate a new Token
                        //Console.WriteLine($"用户 {findUser.Name} 登录成功，新的 Token：{findUser.Token}");
                        Console.WriteLine($"User {findUser.Name} Login successful, new Token：{findUser.Token}");


                        var responseUser = new
                        {
                            Name = findUser.Name,
                            Gold = findUser.Gold,
                            Token = findUser.Token
                        };

                        response.StatusCode = 200; // OK
                        responseString = JsonConvert.SerializeObject(responseUser); 
                    }
                    else
                    {
                        
                        response.StatusCode = 401; // Unauthorized
                        responseString = "Invalid email or password.";
                    }

                    

                }
                else if (method == "POST" && url == "/register")
                {
                    // Registration Logic
                    User userRequest = JsonConvert.DeserializeObject<User>(requestBody);

                    
                    if (users.Exists(u => u.Email == userRequest.Email))
                    {
                        response.StatusCode = 409; 
                        //responseString = "用户已存在。";
                        responseString = "User already exists.";
                    }
                    else
                    {
                        
                        userRequest.Gold = "20"; 
                        userRequest.Token = Guid.NewGuid().ToString(); 
                        users.Add(userRequest);
                       

                        
                        response.StatusCode = 201;
                        //responseString = "注册成功";
                        responseString = "Successful registration";
                    }
                }
                else
                {
                    response.StatusCode = 404;
                    //responseString = "未找到请求的资源。";
                    responseString = "The requested resource was not found.";
                }
            }
            catch (Exception ex)
            {
                response.StatusCode = 500;
                //responseString = $"服务器错误：{ex.Message}";
                responseString = $"Server Error：{ex.Message}";
            }

          
            byte[] buffer = Encoding.UTF8.GetBytes(responseString);
            response.ContentLength64 = buffer.Length;
            response.ContentType = "text/plain; charset=UTF-8";
            await response.OutputStream.WriteAsync(buffer, 0, buffer.Length);
            response.Close();

            Console.WriteLine("Response sent.");
        }
    }
}

