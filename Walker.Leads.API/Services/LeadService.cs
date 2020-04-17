using System;
using System.Collections.Generic;
using Walker.API.Interfaces;
using Walker.API.Model;

namespace Walker.API.Services
{
    public class LeadService : ILeadService
    {
        //Ideally you would have a dbcontext here and inject the DbContext in startup.cs
        //private readonly LeadContext _leadContext; 
        public List<Lead> leads;

        public LeadService()
        {
            leads = new List<Lead>();
        }
        public List<Lead> GetLeads()
        {
            return leads;
        }

        public void SaveLead(Lead lead)
        {
            //if saving to database, context.Leads.Add(lead) and etc.
            leads.Add(lead);
            switch (lead.ContactPermission)
            {
                case Enums.ContactPermission.CanEmailAndText:
                    SendEmailToLead(lead);
                    SendTextToLead(lead);
                    break;
                case Enums.ContactPermission.CanEmail:
                    SendEmailToLead(lead);
                    break;
                case Enums.ContactPermission.CanText:
                    SendTextToLead(lead);
                    break;
            }
        }

        public void SendEmailToLead(Lead lead)
        {
            if(!String.IsNullOrEmpty(lead.Email))
            {
                //assumes using an email library
                //Email.Body = "We have received 
                //EmailService.Send(lead.email);
            }
        }

        public void SendTextToLead(Lead lead)
        {
            //assumes using a library like twilio
            //Twilio.Text(lead.PhoneNumber)
        }
    }
}
