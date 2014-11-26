using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CollectionJson;
using WebApiSandbox.Models;


namespace WebApiSandbox.Infrastructure
{
    public class UserDocumentWriter:ICollectionJsonDocumentWriter<User>
    {
        public IReadDocument Write(IEnumerable<User> data)
        {
            throw new NotImplementedException();
        }
    }
}