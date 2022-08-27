using System;
using KundeApp1.models;
using Microsoft.AspNetCore.Mvc;

namespace KundeApp1.Controller
{   // denne metoden implementerer kontoller base
    [Route("[controller]/[action]")] //viser hvordan vi kan rope på denne funks
    public class KundeController : ControllerBase
    {
        public List<Kunde> HentAlle()
        {
            var kundene = new List<Kunde>();

            var kunde1 = new Kunde();
            kunde1.navn = "Per Hansen";
            kunde1.adresse = "Osloveien 11E";

            var kunde2 = new Kunde
            {
                navn = "Line Kristoffersen",
                adresse = "Hamargata 22B"
            };

            kundene.Add(kunde1);
            kundene.Add(kunde2);

            return kundene;
        }
    }
}

