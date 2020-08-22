using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RafsWeb.EmailSender
{
    public class MailModel
    {
        [EmailAddress]
        public string Sender { get; set; }

        public string Subject { get; set; }

        [Required]
        [MinLength(2)]
        public string Body { get; set; }

    }
}
