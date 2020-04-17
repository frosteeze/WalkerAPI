using System.Collections.Generic;
using Walker.API.Model;

namespace Walker.API.Interfaces
{
    public interface ILeadService
    {
        //Ideally interfaces are stored in a shared project

        void SaveLead(Lead lead);
        List<Lead> GetLeads();
        void SendTextToLead(Lead lead);
        void SendEmailToLead(Lead lead);
    }
}
