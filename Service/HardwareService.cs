using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Firebase.Xamarin.Database;
using RepostaryXamarinForms.Model;

namespace RepostaryXamarinForms.Service
{
    public class HardwareService
    {
        public HardwareService()
        {
        }

        public async Task<List<T>> Getlist<T>(){

            try
            {
                var list = await App.firebaseClient.Child(typeof(T).Name).OnceAsync<T>();
                return list.Select((arg) => {
                    return arg.Object;
                }).ToList();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("hata" + ex.Message);
                return null;

            }

          
        }

        public async Task<Boolean> Postlist<T>(T data)
        {
            var client = new FirebaseClient("https://fir-blogapp-1e856.firebaseio.com/");
            var post = await client.Child(typeof(T).Name).PostAsync<T>(data);
            if (post != null) return true;
            else return false;

        }

        public async Task<Boolean> Putlist<T>(T data)
        {
            try
            {
                var client = new FirebaseClient("https://fir-blogapp-1e856.firebaseio.com/");
                await client.Child(typeof(T).Name).PutAsync<T>(data);
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public async Task<Boolean> Removelist<T>(T data,string key)
        {
            try
            {
                var client = new FirebaseClient("https://fir-blogapp-1e856.firebaseio.com/");
                await client.Child(typeof(T).Name+"/"+key).DeleteAsync();
                return true; 

            }
            catch (Exception ex)
            {
                return false;
            }

        }




      



    }
}
