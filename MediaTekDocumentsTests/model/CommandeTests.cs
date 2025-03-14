﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediaTekDocuments.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MediaTekDocuments.model.Tests
{
     [TestClass()]
     public class CommandeTests
     {
          private const string id = "0005";
          private static readonly DateTime dateCommande = DateTime.Now;
          private const double montant = 22.4;
          private static readonly Commande commande = new Commande(id, dateCommande, montant);
          [TestMethod()]
          public void CommandeTest()
          {
               NUnit.Framework.Assert.AreEqual(id, commande.Id, "devrait réussir : id valorisé");
               NUnit.Framework.Assert.AreEqual(dateCommande, commande.DateCommande, "devrait réussir : date de commande valorisée");
               NUnit.Framework.Assert.AreEqual(montant, commande.Montant, "devrait réussir : montant valorisé");
          }
     }
}
