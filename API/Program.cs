using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

//Antes de criar a API , instalar no pacote de Nuget: Newtonsoft.Json
// HttpClient : Usado para fazer requisições HTTP, como GET,POST, PUT, DELETE.

// GetAsync: Método assíncrono usado para fazer requisição GET.

//ReadAsStringAsync: Le a resposta da API como uma string.

// JsonCovert.DeserializeObject: Usado para converter o Json da resposta em um Objeto C#

//Quando voce marca um metodo como async , o compilador permite o uso de await dentro dele,
//que é a palavra chave que indica onde o código deve esperar por uma operação assincroma. 

//quando usa o VOID: ele não retorna nenhum valor, ele apenas executa a ação de imprimir
//os dados, sempre depende de algum recurso para exigir algo. EX: Console.Write
namespace API
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Criação da instancia HTTPCLIENTE
            HttpClient client = new HttpClient();
           
            //Define a URL do API
            string apiUrl = "https://economia.awesomeapi.com.br/last/EUR-BRL";

            try
            {
                //Enviar uma  requisição GET para API
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    //Ler o conteúdo da resposta como uma string
                    string jsonResult = await response.Content.ReadAsStringAsync();
                    var jsonObject = JsonConvert.DeserializeObject<dynamic>(jsonResult);
                   
                    //Converter p JSON para um objeto C#
                    Console.WriteLine("Resposta da API:");
                    
                    //Exibir o Resultado
                    //Console.WriteLine(jsonResult);


                    foreach ( var produto in jsonObject) 
                    {
                    Console.WriteLine($"\nNome: {produto.title}" +
                     $" Nota: {produto.rating.rate}");
                    }
                }
                else
                {
                    Console.WriteLine($"Erro na requisição: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            finally
            {
                client.Dispose();
            }



        }
    }
}
