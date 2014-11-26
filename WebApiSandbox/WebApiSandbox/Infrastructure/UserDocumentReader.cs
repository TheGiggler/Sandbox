using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CollectionJson;
using WebApiSandbox.Models;

namespace WebApiSandbox.Infrastructure
{
    public class UserDocumentReader:ICollectionJsonDocumentReader<User>
    {
        public User Read(IWriteDocument document)
        {
            throw new NotImplementedException();
        }
    }
}