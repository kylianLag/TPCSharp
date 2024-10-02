using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeJustePrix
{
    public class Vitrine
    {
        public List<Article> listArticle;

        public Vitrine()
        {
            listArticle = new List<Article>();
        }



        public int prixTotal()
        {
            int total = 0;
            for(int i = 0; i < this.listArticle.Count; i++)
            {
                total = total + this.listArticle[i].getPrix();
            }
            return total;
        }


        public void add(Article article)
        {
            listArticle.Add(article);
        }

       
    }
}
