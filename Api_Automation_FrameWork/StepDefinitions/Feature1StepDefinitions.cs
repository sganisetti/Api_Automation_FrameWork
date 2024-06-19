using System;
using Api_Automation_FrameWork.CrudUtilities;

using Reqnroll;

namespace Api_Automation_FrameWork.StepDefinitions
{
    [Binding]
    public class Feature1StepDefinitions
    {
        [Given("I created new Request {int} {string} and {int}")]
        public void GivenICreatedNewRequestAnd(int userId, string title, int id)
        {
         var response =   PostUtills.CreatePost(userId,title,id);
            Assert.AreEqual(response.userId,userId);
            Assert.AreEqual(response.title,title);
            Assert.AreEqual(response.id,id);

        }
        [Given("I Get the Data with {int}")]
        public void GivenIGetTheDataWith(int id)
        {
           var Get =  PostUtills.GetData(id);
        }

        [Given("I Deleted the Request  Request {int} {string} and {int}")]
        public void GivenIDeletedTheRequestRequestAnd(int id, string name, int userId)
        {
           var responseDel = PostUtills.Delete(id);
        }

    }
}
