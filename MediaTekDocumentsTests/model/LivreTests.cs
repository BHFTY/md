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
     public class LivreTests
     {
          private const string id = "00001";
          private const string titre = "Accelerando";
          private const string image = "https://e5v8x4i7.stackpathcdn.com/wp-content/uploads/2016/01/strosscother05accelerando-txt.jpg";
          private const string isbn = "0-441-01284-1";
          private const string auteur = "Charles Stross";
          private const string collection = "Incertain futur";
          private const string idGenre = "99999";
          private const string genre = "science-fiction";
          private const string idPublic = "00333";
          private const string lePublic = "nerd";
          private const string idRayon = "Aeλx";
          private const string rayon = "Livre|Littérature|Science-fiction";
          private static readonly Livre livre = new Livre(id, titre, image, isbn, auteur, collection,
              idGenre, genre, idPublic, lePublic, idRayon, rayon);
          [TestMethod()]
          public void LivreTest()
          {
               NUnit.Framework.Assert.AreEqual(id, livre.Id, "devrait réussir : id valorisé");
               NUnit.Framework.Assert.AreEqual(titre, livre.Titre, "devrait réussir : titre valorisé");
               NUnit.Framework.Assert.AreEqual(image, livre.Image, "devrait réussir : image valorisée");
               NUnit.Framework.Assert.AreEqual(isbn, livre.Isbn, "devrait réussir : isbn valorisé");
               NUnit.Framework.Assert.AreEqual(auteur, livre.Auteur, "devrait réussir : auteur valorisé");
               NUnit.Framework.Assert.AreEqual(collection, livre.Collection, "devrait réussir : collection valorisée");
               NUnit.Framework.Assert.AreEqual(idGenre, livre.IdGenre, "devrait réussir : idGenre valorisé");
               NUnit.Framework.Assert.AreEqual(genre, livre.Genre, "devrait réussir : genre valorisé");
               NUnit.Framework.Assert.AreEqual(idPublic, livre.IdPublic, "devrait réussir : idPublic valorisé");
               NUnit.Framework.Assert.AreEqual(lePublic, livre.Public, "devrait réussir : public valorisé");
               NUnit.Framework.Assert.AreEqual(idRayon, livre.IdRayon, "devrait réussir : idRayon valorisé");
               NUnit.Framework.Assert.AreEqual(rayon, livre.Rayon, "devrait réussir : rayon valorisé");
          }
     }
}
