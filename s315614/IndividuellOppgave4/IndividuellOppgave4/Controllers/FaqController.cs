using FAQDataaccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace IndividuellOppgave4.Controllers
{
    public class FaqController : ApiController
    {
        public HttpResponseMessage Get(string title="All")
        {
            using(DatabaseEntities entities = new DatabaseEntities())
            {
                switch (title.ToLower())
                {
                    case "all":
                        return Request.CreateResponse(HttpStatusCode.OK, entities.FaqDatabases.ToList());
                    case "funksjonalitet":
                        return Request.CreateResponse(HttpStatusCode.OK, entities.FaqDatabases.Where(f => f.Title.ToLower() == "funksjonalitet").ToList());
                    case "aktuelt":
                        return Request.CreateResponse(HttpStatusCode.OK, entities.FaqDatabases.Where(f => f.Title.ToLower() == "aktuelt").ToList());
                    case "konto og betaling":
                        return Request.CreateResponse(HttpStatusCode.OK, entities.FaqDatabases.Where(f => f.Title.ToLower() == "konto og betaling").ToList());
                    case "hjelp og feilsøking":
                        return Request.CreateResponse(HttpStatusCode.OK, entities.FaqDatabases.Where(f => f.Title.ToLower() == "hjelp og feilsøking").ToList());
                    case "finn og se":
                        return Request.CreateResponse(HttpStatusCode.OK, entities.FaqDatabases.Where(f => f.Title.ToLower() == "finn og se").ToList());
                    case "om oslomet films":
                        return Request.CreateResponse(HttpStatusCode.OK, entities.FaqDatabases.Where(f => f.Title.ToLower() == "om oslomet films").ToList());

                    default:
                        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Value for Title " +title+ " is not found");

                }

            }
            
        }
        
        public HttpResponseMessage Get(int id)
        {
            using(DatabaseEntities entities = new DatabaseEntities())
            {
                var entity = entities.FaqDatabases.FirstOrDefault(e => e.Id == id);
                
                
                if(entity != null)
                {
                   
                    return Request.CreateResponse(HttpStatusCode.OK, entity);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Finner ikke i databasen");
                }
            }
        }
        
        //for adding
        public HttpResponseMessage Post([FromBody] NewQuestion newQuestion)
        {
            try
            {
                using (DatabaseEntities entities = new DatabaseEntities())
                {
                    entities.NewQuestions.Add(newQuestion);
                    entities.SaveChanges();
                    var message = Request.CreateResponse(HttpStatusCode.Created, newQuestion);
                    message.Headers.Location = new Uri(Request.RequestUri + newQuestion.Id.ToString());
                    return message;
                }
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
            
        }
        //edit
        [HttpPut]
        public HttpResponseMessage Put(int id, [FromBody] FAQDatabase thumbsUp)
        {
            try
            {
                using(DatabaseEntities entities = new DatabaseEntities())
                {
                    var entity = entities.FaqDatabases.FirstOrDefault(e => e.Id == id);
                    if (entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "We could not find " + id.ToString() + " id");
                    }
                    else
                    {
                        entity.ThumbsDown = thumbsUp.ThumbsDown;
                        entity.ThumbsUp = thumbsUp.ThumbsUp;
                        entities.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK, entity);
                    }
                }
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        
    }
}
