using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediaTekDocuments.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MediaTekDocuments.model.Tests
{
     [TestClass()]
     public class CommandeDocumentTests
     {
          private const string id = "0008";
          private static readonly DateTime dateCommande = DateTime.Now;
          private const float montant = 24.34F;
          private const int nbExemplaire = 2;
          private const string idLivreDvd = "0003";
          private const int idSuivi = 4;
          private const string etat = "Neuf";
          private static readonly CommandeDocument commandeDocument = new CommandeDocument(id, dateCommande, montant, nbExemplaire
              , idLivreDvd, idSuivi, etat);
          [TestMethod()]
          public void CommandeDocumentTest()
          {
               NUnit.Framework.Assert.AreEqual(id, commandeDocument.Id, "devrait réussir : id valorisé");
               NUnit.Framework.Assert.AreEqual(dateCommande, commandeDocument.DateCommande, "devrait réussir : date de commande valorisée");
               NUnit.Framework.Assert.AreEqual(montant, commandeDocument.Montant, "devrait réussir : montant valorisé");
               NUnit.Framework.Assert.AreEqual(nbExemplaire, commandeDocument.NbExemplaire, "devrait réussir : nbExemplaire valorisé");
               NUnit.Framework.Assert.AreEqual(idLivreDvd, commandeDocument.IdLivreDvd, "devrait réussir : idLivreDvd valorisé");
               NUnit.Framework.Assert.AreEqual(idSuivi, commandeDocument.IdSuivi, "devrait réussir : idSuivi valorisé");
               NUnit.Framework.Assert.AreEqual(etat, commandeDocument.Etat, "devrait réussir : etat valorisé");
          }
     }
}
