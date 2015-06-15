using System;
using System.Collections;
using System.Linq;
using System.Text;


namespace Priority_Queue
{
    public struct pqItem
    {
        public int? priority;
        public string name;
    }


    public class PQueue: Queue
    {
        object[] Items;
        pqItem[] Pqs;
        int count =0;
        public PQueue()
            : base() // call base constructor
        {   }


        public override object Dequeue()
        {
            if(count ==0)
            {
            Items = this.ToArray();
            Pqs = new pqItem[Items.Count()];

            for (int i = 0; i < (Items.Length); i++)
            {
                if (((pqItem)Items[i]).name != null)
                {
                    Pqs[i] = (pqItem)Items[i];
                }

            }
            }
            
            
            int x, min, minindex;




            int? min1 = Pqs.Min(c => c.priority);
            min = (int)min1;
            minindex=0;
           
            for (int i = 0; i < (Items.Length); i++)
            {
                if (((pqItem)Pqs[i]).priority != null   )
                {
                int psqP = (int)((pqItem)Items[i]).priority;

                if (psqP <= min)
                {
                    min = psqP;
                    minindex = i;
                    break; // since a queue so lets return the first occurance
                
                }
                }

            }
            
            var u = Pqs[minindex];
            Pqs[minindex].name = null;
            Pqs[minindex].priority = null;
            

            count++;
           return u;
            //ArrayList items = new ArrayList(this.ToArray());


        }

        static void Main()
        {
            PQueue erwait = new PQueue();
            pqItem[] erPatient = new pqItem[3];
            pqItem nextPatient;
            erPatient[0].name = "Joe Smith";
            erPatient[0].priority = 1;
            erPatient[1].name = "Mary Brown";
            erPatient[1].priority = 0;
            erPatient[2].name = "Sam Jones";
            erPatient[2].priority = 5;
            pqItem hh = new pqItem() { name = "John Builder", priority = 0 };
           
            for (int x = 0; x <erPatient.Length; x++)
                erwait.Enqueue(erPatient[x]);
            erwait.Enqueue(hh);
            nextPatient = (pqItem)erwait.Dequeue();
            Console.WriteLine(nextPatient.name);
            nextPatient = (pqItem)erwait.Dequeue();
            Console.WriteLine(nextPatient.name);
            nextPatient = (pqItem)erwait.Dequeue();
            Console.WriteLine(nextPatient.name);
            nextPatient = (pqItem)erwait.Dequeue();
            Console.WriteLine(nextPatient.name);

        }

       

    }
}

