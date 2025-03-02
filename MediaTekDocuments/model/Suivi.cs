
namespace MediaTekDocuments.model
{
     public class Suivi
     {
          public int Id { get; }
          public string Etat { get; }

          public Suivi(int id, string etat)
          {
               this.Id = id;
               this.Etat = etat;
          }

          public override string ToString()
          {
               return this.Etat;
          }


     }

}
