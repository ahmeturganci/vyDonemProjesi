using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vyDonemProjesi
{
    public class BaglıListe:BagliListeADT
    {
        public override void InsertFirst(int value)
        {
            Node tmpHead = new Node
            {
                Data = value
            };

            if (Head == null)
                Head = tmpHead;
            else
            {
                //En kritik nokta: tmpHead'in next'i eski Head'i göstermeli
                tmpHead.Next = Head;
                //Yeni Head artık tmpHead oldu
                Head = tmpHead;
            }
            //Bağlı listedeki eleman sayısı bir arttı
            Size++;
        }

        public override void InsertLast(int value)
        {
            //insert last işlemi başarı ile gerçekleşiyor.
            Node newLast = new Node();
            if (Head == null)
            {
                newLast.Data = value;
                Head = newLast;
                return;
            }
            Node curr = Head;
            while (curr.Next != null)
            {
                curr = curr.Next;
            }
            newLast.Data = value;
            curr.Next = newLast;
            Size++;

        }

        public override void InsertPos(int position, int value)
        {
            Node newNode = new Node { Data = value };
            Node posNode = null;
            Node tempNext = null;
            if (Head == null)
                InsertFirst(value);
            else
            {
                posNode = GetElement(position);
                tempNext = posNode.Next;
                posNode.Next = newNode;
                newNode.Next = tempNext;
            }
            Size++;
        }

        public override void DeleteFirst()
        {
            if (Head != null)
            {
                //Head'in next'i HeadNext'e atanıyor
                Node HeadNext = this.Head.Next;
                //HeadNext null ise zaten tek kayıt olan Head silinir.
                if (HeadNext == null)
                    Head = null;
                else
                    //HeadNext null değilse yeni Head, HeadNext olur.
                    Head = HeadNext;
                //Listedeki eleman sayısı bir azaltılıyor
                Size--;
            }
        }

        public override void DeleteLast()
        {
            Node item = Head;
            int i = 1;
            while (item != null)
            {
                if (i == Size - 1)
                {
                    item.Next = null;
                    break;
                }
                item = item.Next;
                i++;
            }
            Size--;

        }
        public override void DeletePos(int position)
        {

            Node item = Head;
            Node pos = null;
            if (position == 0) //head
            {
                DeleteFirst();
                return;
            }
            pos = GetElement(position);
            item = GetElement(position - 1);
            item.Next = pos.Next;
            pos = null;
            Size--;
        }

        public override Node GetElement(int position)
        {
            Node item = Head;
            Node pos = null;
            int i = 0;
            while (item != null)
            {
                if (i == position)
                {
                    pos = item;
                }
                item = item.Next;
                i++;
            }
            return pos;
        }

        public override string DisplayElements()
        {
            string temp = "";
            Node item = Head;
            while (item != null)
            {
                temp += "-->" + item.Data;
                item = item.Next;
            }

            return temp;
        }
    }
    
}
