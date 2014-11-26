using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CollectionJson.Server;
using WebApiSandbox.Models;
using CollectionJson.Client;
using CollectionJson;

namespace WebApiSandbox.Controllers
{
    public class UsersController : CollectionJsonController<User>
    {
        public UsersController(ICollectionJsonDocumentWriter<User> writer, ICollectionJsonDocumentReader<User> reader)
            : base(writer, reader)
        {

        }
        protected override int Create(CollectionJson.IWriteDocument document, HttpResponseMessage response)
        {
            return base.Create(document, response);
        }
    }
}
