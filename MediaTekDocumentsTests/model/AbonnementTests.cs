using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediaTekDocuments.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace MediaTekDocuments.model.Tests
{
     [TestClass()]
     public class AbonnementTests
     {
          private const string id = "0008";
          private static readonly DateTime dateCommande = DateTime.Now;
          private const double montant = 25.32;
          private static readonly DateTime dateFinAbonnement = DateTime.Now.AddMonths(2);
          private const string idRevue = "0003";
          private static readonly Abonnement abonnement = new Abonnement(id, dateCommande, montant, dateFinAbonnement, idRevue);
          [TestMethod()]
          public void AbonnementTest()
          {
               NUnit.Framework.Assert.AreEqual(id, abonnement.Id, "devrait réussir : id valorisé");
               NUnit.Framework.Assert.AreEqual(dateCommande, abonnement.DateCommande, "devrait réussir : date de commande valorisée");
               NUnit.Framework.Assert.AreEqual(montant, abonnement.Montant, "devrait réussir : montant valorisé");
               NUnit.Framework.Assert.AreEqual(dateFinAbonnement, abonnement.DateFinAbonnement, "devrait réussir : date de fin d'abonnement valorisée");
               NUnit.Framework.Assert.AreEqual(idRevue, abonnement.IdRevue, "devrait réussir : idRevue valorisé");
          }
     }
}