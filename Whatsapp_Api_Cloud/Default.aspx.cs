using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Whatsapp_Api_Cloud
{
    public partial class _Default : Page
    {
        string token_authorization = "EAAFwOq3r3e0BACtXrd2w654IHX8lPl7mg2ZApt9mWnhQuBygHBCVJTpewqZBNo7iJL3H2tfsft7whKjdIPB6ZAwX3JCY5z1gvepdk79lcWQzQQUJyFnetXfCA1vp15cQ2JBcjFZAZChq0Bffe2ZB9z6CbHjvhpjPWWeFLa5HldeDPlVaHoX1W5";
        string num_whatsapp_business = "111640231639673";
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        public void send_whatsapp_hello_world(string numero)
        {

            var url = "https://graph.facebook.com/v13.0/" + num_whatsapp_business + "/messages";

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Method = "POST";

            httpRequest.Headers["Authorization"] = "Bearer " + token_authorization;
            httpRequest.ContentType = "application/json";

            var data = "{ \"messaging_product\": \"whatsapp\", \"to\": \"" + numero + " \", \"type\": \"template\", \"template\": { \"name\": \"hello_world\", \"language\": { \"code\": \"en_US\" } } }";

            using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
            {
                streamWriter.Write(data);
            }

            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }

            Console.WriteLine(httpResponse.StatusCode);

        }

        public void send_whatsapp_template_texto(string numero, string variable_1, string variable_2)
        {
            var url = "https://graph.facebook.com/v13.0/" + num_whatsapp_business + "/messages";

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Method = "POST";

            httpRequest.Headers["Authorization"] = "Bearer " + token_authorization;
            httpRequest.ContentType = "application/json";

            var data = @"{
           ""messaging_product"": ""whatsapp"",
           ""to"": """ + numero + @""",
           ""type"": ""template"",
           ""template"": {
           ""name"": ""alerta_pedido"",
           ""language"": {
           ""code"": ""es""
                          },
           ""components"": [
            {
           ""type"": ""body"",
           ""parameters"": [
          {
            ""type"": ""text"",
            ""text"": """ + variable_1 + @"""
          },
          {
            ""type"": ""text"",
            ""text"": """ + variable_2 + @"""
          }   

         ]
        }
       ]
      }
     }";

            using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
            {
                streamWriter.Write(data);
            }

            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }

            Console.WriteLine(httpResponse.StatusCode);


        }

        public void send_whatsapp_template_texto_unico(string numero, string variable_1)
        {
            var url = "https://graph.facebook.com/v13.0/" + num_whatsapp_business + "/messages";

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Method = "POST";

            httpRequest.Headers["Authorization"] = "Bearer " + token_authorization;
            httpRequest.ContentType = "application/json";

            var data = @"{
           ""messaging_product"": ""whatsapp"",
           ""to"": """ + numero + @""",
           ""type"": ""template"",
           ""template"": {
           ""name"": ""alerta_ws"",
           ""language"": {
           ""code"": ""es""
                          },
           ""components"": [
            {
           ""type"": ""body"",
           ""parameters"": [
          {
            ""type"": ""text"",
            ""text"": """ + variable_1 + @"""
          }
         
         ]
        }
       ]
      }
     }";

            using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
            {
                streamWriter.Write(data);
            }

            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }

            Console.WriteLine(httpResponse.StatusCode);


        }


        public void send_whatsapp_template_texto_header(string numero, string header, string body)
        {
            var url = "https://graph.facebook.com/v13.0/" + num_whatsapp_business + "/messages";

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Method = "POST";

            httpRequest.Headers["Authorization"] = "Bearer " + token_authorization;
            httpRequest.ContentType = "application/json";

            var data = @"{
           ""messaging_product"": ""whatsapp"",
           ""to"": """ + numero + @""",
           ""type"": ""template"",
           ""template"": {
           ""name"": ""alerta_ws_header"",
           ""language"": {
           ""code"": ""es""
                          },
           ""components"": [
            {
           ""type"": ""header"",
           ""parameters"": [
             {
            ""type"": ""text"",
            ""text"": """ + header + @"""
              }        
                           ]
             },
            {
              ""type"": ""body"",
           ""parameters"": [
             {
            ""type"": ""text"",
            ""text"": """ + body + @"""
              }        
                           ]
            }
       ]
      }
     }";

            using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
            {
                streamWriter.Write(data);
            }

            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }

            Console.WriteLine(httpResponse.StatusCode);


        }

        public void send_whatsapp_imagen_link(string numero, string link)
        {
            var url = "https://graph.facebook.com/v13.0/" + num_whatsapp_business + "/messages";

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Method = "POST";

            httpRequest.Headers["Authorization"] = "Bearer " + token_authorization;
            httpRequest.ContentType = "application/json";

            var data = @"{
            ""messaging_product"": ""whatsapp"",
            ""to"": """ + numero + @""",
            ""type"": ""template"",
            ""template"": {
             ""name"": ""imagen_ws"",
             ""language"":    {
             ""code"": ""es""
                               },
                 ""components"": [
                                    {
                                 ""type"": ""header"",
                        ""parameters"": [
                                        {
                                          ""type"": ""image"",
                                        ""image"": {""link"":""" + link + @"""}
                                         }
         
                                        ]
                                     }
                                  ]
                           }
                        }";

            using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
            {
                streamWriter.Write(data);
            }

            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }

            Console.WriteLine(httpResponse.StatusCode);

        }

        public void send_whatsapp_imagen_id(string numero, string id)
        {
            try
            {
                var url = "https://graph.facebook.com/v13.0/" + num_whatsapp_business + "/messages";

                var httpRequest = (HttpWebRequest)WebRequest.Create(url);
                httpRequest.Method = "POST";

                httpRequest.Headers["Authorization"] = "Bearer " + token_authorization;
                httpRequest.ContentType = "application/json";

                var data = @"{
            ""messaging_product"": ""whatsapp"",
            ""to"": """ + numero + @""",
            ""type"": ""template"",
            ""template"": {
             ""name"": ""imagen_ws"",
             ""language"":    {
             ""code"": ""es""
                               },
                 ""components"": [
                                    {
                                 ""type"": ""header"",
                        ""parameters"": [
                                        {
                                          ""type"": ""image"",
                                        ""image"": {""id"":""" + id + @"""}
                                         }
         
                                        ]
                                     }
                                  ]
                           }
                        }";

                using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
                {
                    streamWriter.Write(data);
                }

                var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                }

                Console.WriteLine(httpResponse.StatusCode);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


        }

        public void send_whatsapp_imagen_texto_id(string numero, string body, string id)
        {
            try
            {
                var url = "https://graph.facebook.com/v13.0/" + num_whatsapp_business + "/messages";

                var httpRequest = (HttpWebRequest)WebRequest.Create(url);
                httpRequest.Method = "POST";

                httpRequest.Headers["Authorization"] = "Bearer " + token_authorization;
                httpRequest.ContentType = "application/json";

                var data = @"{
            ""messaging_product"": ""whatsapp"",
            ""to"": """ + numero + @""",
            ""type"": ""template"",
            ""template"": {
             ""name"": ""imagen_ws_y_texto"",
             ""language"":    {
             ""code"": ""es""
                               },
                 ""components"": [
                                    {
                                 ""type"": ""header"",
                        ""parameters"": [
                                        {
                                          ""type"": ""image"",
                                        ""image"": {""id"":""" + id + @"""}
                                         }
         
                                        ]
                                     },
                                    {
                                 ""type"": ""body"",
                        ""parameters"": [
                                        {
                                          ""type"": ""text"",
                                         ""text"": """ + body + @"""
                                         }
         
                                        ]
                                     }
                                  ]
                           }
                        }";

                using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
                {
                    streamWriter.Write(data);
                }

                var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                }

                Console.WriteLine(httpResponse.StatusCode);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }

        public void send_whatsapp_video_texto_id(string numero, string body, string id)
        {
            try
            {
                var url = "https://graph.facebook.com/v13.0/" + num_whatsapp_business + "/messages";

                var httpRequest = (HttpWebRequest)WebRequest.Create(url);
                httpRequest.Method = "POST";

                httpRequest.Headers["Authorization"] = "Bearer " + token_authorization;
                httpRequest.ContentType = "application/json";

                var data = @"{
            ""messaging_product"": ""whatsapp"",
            ""to"": """ + numero + @""",
            ""type"": ""template"",
            ""template"": {
             ""name"": ""ws_video_y_texto"",
             ""language"":    {
             ""code"": ""es""
                               },
                 ""components"": [
                                    {
                                 ""type"": ""header"",
                        ""parameters"": [
                                        {
                                          ""type"": ""video"",
                                        ""video"": {""id"":""" + id + @"""}
                                         }
         
                                        ]
                                     },
                                    {
                                 ""type"": ""body"",
                        ""parameters"": [
                                        {
                                          ""type"": ""text"",
                                         ""text"": """ + body + @"""
                                         }
         
                                        ]
                                     }
                                  ]
                           }
                        }";

                using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
                {
                    streamWriter.Write(data);
                }

                var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                }

                Console.WriteLine(httpResponse.StatusCode);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }

        public void send_whatsapp_document_texto_id(string numero, string body, string id, string nombre_archivo)
        {
            try
            {
                var url = "https://graph.facebook.com/v13.0/" + num_whatsapp_business + "/messages";

                var httpRequest = (HttpWebRequest)WebRequest.Create(url);
                httpRequest.Method = "POST";

                httpRequest.Headers["Authorization"] = "Bearer " + token_authorization;
                httpRequest.ContentType = "application/json";

                var data = @"{
            ""messaging_product"": ""whatsapp"",
            ""to"": """ + numero + @""",
            ""type"": ""template"",
            ""template"": {
             ""name"": ""document_ws_y_texto"",
             ""language"":    {
             ""code"": ""es""
                               },
                 ""components"": [
                                    {
                                 ""type"": ""header"",
                        ""parameters"": [
                                        {
                                          ""type"": ""document"",
                                        ""document"": {""id"":""" + id + @""" , ""filename"":""" + nombre_archivo + @"""}
                                         }
         
                                        ]
                                     },
                                    {
                                 ""type"": ""body"",
                        ""parameters"": [
                                        {
                                          ""type"": ""text"",
                                         ""text"": """ + body + @"""
                                         }
         
                                        ]
                                     }
                                  ]
                           }
                        }";

                using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
                {
                    streamWriter.Write(data);
                }

                var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                }

                Console.WriteLine(httpResponse.StatusCode);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }

        public void whatsapp_image_upload_path(string filepath)
        {
            try
            {
                //string filePath = @"C:\Users\cnarea\Pictures\procesos.jpeg";
                var client = new RestClient("https://graph.facebook.com/" + num_whatsapp_business + "/media");
                client.Options.MaxTimeout = -1;
                var request = new RestRequest("",Method.Post);
                request.AddHeader("Authorization", "Bearer " + token_authorization);
                request.AddFile("file", filepath, "image/jpeg");
                request.AddParameter("messaging_product", "whatsapp");
                RestSharp.RestResponse response = client.Execute(request);
                Console.WriteLine(response.Content);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }

        public string whatsapp_image_upload_byte(byte[] byte_image, string nombre_imagen)
        {
            string retorno = string.Empty;
            try
            {
                var client = new RestClient("https://graph.facebook.com/" + num_whatsapp_business + "/media");
                client.Options.MaxTimeout = -1;
                var request = new RestRequest(" ",Method.Post);
                request.AddHeader("Authorization", "Bearer " + token_authorization);
                request.AddFile("file", byte_image, nombre_imagen + ".jpg", "image/jpeg");
                request.AddParameter("messaging_product", "whatsapp");
                RestSharp.RestResponse response = client.Execute(request);
                Console.WriteLine(response.Content);
                if (response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    var array_id = response.Content.Split(':');
                    var string_id = array_id[1].Replace('/', ' ').Replace(@"\", " ").Replace('}', ' ');
                    var string_ = string_id.Replace(@"\", " ");
                    retorno = string_;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return retorno;
        }

        public string whatsapp_video_upload_byte(byte[] byte_video, string nombre_video)
        {
            string retorno = string.Empty;
            try
            {
                var client = new RestClient("https://graph.facebook.com/" + num_whatsapp_business + "/media");
                client.Options.MaxTimeout = -1;
                var request = new RestRequest(" ",Method.Post);
                request.AddHeader("Authorization", "Bearer " + token_authorization);
                request.AddFile("file", byte_video, nombre_video + ".mp4", "video/mp4");
                request.AddParameter("messaging_product", "whatsapp");
                RestResponse response = client.Execute(request);
                Console.WriteLine(response.Content);
                if (response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    var array_id = response.Content.Split(':');
                    var string_id = array_id[1].Replace('/', ' ').Replace(@"\", " ").Replace('}', ' ');
                    var string_ = string_id.Replace(@"\", " ");
                    retorno = string_;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return retorno;
        }

        public string whatsapp_document_upload_byte(byte[] byte_archivo, string nombre_archivo, string tipo_archivo)
        {
            string retorno = string.Empty;
            try
            {
                var client = new RestClient("https://graph.facebook.com/" + num_whatsapp_business + "/media");
                client.Options.MaxTimeout = -1;
                var request = new RestRequest("",Method.Post);
                request.AddHeader("Authorization", "Bearer " + token_authorization);
                if (tipo_archivo == "pdf")
                {
                    request.AddFile("file", byte_archivo, nombre_archivo + ".pdf", "application/pdf");
                }
                else if (tipo_archivo == "word")
                {
                    request.AddFile("file", byte_archivo, nombre_archivo + ".docx", "application/msword");
                }
                else if (tipo_archivo == "excel")
                {
                    request.AddFile("file", byte_archivo, nombre_archivo + ".xlsx", "application/vnd.ms-excel");
                }
                else if (tipo_archivo == "powerpoint")
                {
                    request.AddFile("file", byte_archivo, nombre_archivo + ".pptx", "application/vnd.ms-powerpoint");
                }

                request.AddParameter("messaging_product", "whatsapp");
                RestResponse response = client.Execute(request);
                Console.WriteLine(response.Content);
                if (response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    var array_id = response.Content.Split(':');
                    var string_id = array_id[1].Replace('/', ' ').Replace(@"\", " ").Replace('}', ' ');
                    var string_ = string_id.Replace(@"\", " ");
                    retorno = string_;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return retorno;
        }

        protected void btn_enviar_mensaje_Click(object sender, EventArgs e)
        {
            //string filePath = @"C:\Users\cnarea\Pictures\procesos.jpeg";
            //whatsapp_image_upload_path(filePath);
            //send_whatsapp_imagen_id("593985517569", "1097244920952078");
            send_whatsapp_template_texto_header("593985517569", txt_cabecera_mensaje.Text, txt_cuerpo_mensaje.Text);
        }
    }
}