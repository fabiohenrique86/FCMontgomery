using FCMontgomery.Business;
using FCMontgomery.Business.Exceptions;
using FCMontgomery.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace FCMontgomery.Web.Controllers
{
    public class ContactController : Controller
    {
        private ContactBusiness contactBusiness;

        public ContactController()
        {
            contactBusiness = new ContactBusiness();
        }

        [HttpPost]
        public JsonResult Send(ContactDto contactDto)
        {
            try
            {
                contactBusiness.ValidSend(contactDto);

                var smtp = new SmtpClient();
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("contato@chicodocolchao.com.br", "c0nt4t0");
                smtp.Port = 587;
                smtp.Host = "smtpi.chicodocolchao.com.br";
                var mail = new MailMessage();                
                mail.From = new MailAddress("contato@chicodocolchao.com.br"); 
                mail.To.Add("mateusc.eng@gmail.com"); //brunomr@fcmontgomery.com
                mail.Subject = "Contact Us-Website";
                mail.Body = "This email was sent by : \n" + contactDto.Name + "\n" + contactDto.Email + "\n" + contactDto.Phone + "\n" + contactDto.Message;

                smtp.Send(mail);
                
                return Json(new { Sucesso = true, Mensagem = "Message sent successfully" }, JsonRequestBehavior.AllowGet);
            }
            catch (BusinessException ex)
            {
                return Json(new { Sucesso = false, Mensagem = ex.Message }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { Sucesso = false, Mensagem = "An error occured. Message wasn't send it. Try again", Erro = ex.ToString() }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}