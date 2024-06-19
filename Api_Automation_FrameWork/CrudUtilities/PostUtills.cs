using Api_Automation_FrameWork.Requests;
using Api_Automation_FrameWork.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Api_Automation_FrameWork.CrudUtilities
{
    public class PostUtills
    {
        public static CreateRequest CreatePost(int userId, string title, int id)
        {
            return RestClientUtilities.Post<CreateRequest>("/albums", CreateRequest(userId, title, id));
        }

        public static string CreateRequest(int userId, string title, int id)
        {
            CreateRequest request = new CreateRequest();
            request.userId = userId;
            request.title = title;
            request.id = id;
            return JsonConvert.SerializeObject(request);
        }
        public static bool Delete(int id)
        {
          return  RestClientUtilities.Delete<CreateRequest>("/albums" + id.ToString(), HttpStatusCode.OK);
        }
        public static CreateRequest GetData(int id)
        {
          return   RestClientUtilities.Get<CreateRequest>("/albums" + id.ToString(), HttpStatusCode.OK);
        }

    }
}
