using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vyDonemProjesi
{

    public class Heap
    {
        public HeapDugumu[] heapArray;
        private int maxSize;
        private int currentSize;
        public Heap(int maxHeapSize)
        {
            maxSize = maxHeapSize;
            currentSize = 0;
            heapArray = new HeapDugumu[maxSize];
        }
        public bool IsEmpty()
        {
            return currentSize == 0;
        }
        public bool Insert(Kisi value)
        {
            if (currentSize == maxSize)
                return false;
            HeapDugumu newHeapDugumu = new HeapDugumu(value);
            heapArray[currentSize] = newHeapDugumu;
            MoveToUp(currentSize++);
            return true;
        }
        public void MoveToUp(int index)
        {
            int parent = (index - 1) / 2;
            HeapDugumu bottom = heapArray[index];

            while (index > 0 && (heapArray[parent].Deger.Ad).CompareTo(bottom.Deger.Ad) < 0)//çevirmek
            {
                heapArray[index] = heapArray[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            heapArray[index] = bottom;
        }
        public HeapDugumu Remove(int index) // ilana başvuran kişiyi heapten siliyoruz
        {
            HeapDugumu root = heapArray[index];
            heapArray[index] = heapArray[--currentSize];
            MoveToDown(index);
            return root;
        }
        public void MoveToDown(int index)
        {
            int largerChild;
            HeapDugumu top = heapArray[index];
            while (index < currentSize / 2)
            {
                int leftChild = 2 * index + 1;
                int rightChild = leftChild + 1;
                if (rightChild < currentSize && (heapArray[leftChild].Deger.Ad).CompareTo(heapArray[rightChild].Deger.Ad) > 0)
                    largerChild = rightChild;
                else
                    largerChild = leftChild;
                if ((top.Deger.Ad).CompareTo(heapArray[largerChild].Deger.Ad) <= 0)
                    break;
                heapArray[index] = heapArray[largerChild];
                index = largerChild;
            }
            heapArray[index] = top;
        }
        //public void kisiBasvuruKontrol(string eskiKisiAdi, Kisi yeniKisi)
        //{
        //    for (int m = 0; m < currentSize; m++)
        //    {
        //        if (heapArray[m] != null)
        //        {
        //            if (eskiKisiAdi == heapArray[m].Deger.Ad)
        //            {
        //                heapArray[m].Deger = yeniKisi;
        //            }
        //        }
        //    }
        //}
        public bool basvuruKontrol(Kisi kisi)
        {
            bool kontrol = false;
            for (int m = 0; m < currentSize; m++)
            {
                if (heapArray[m] != null)
                {
                    if (kisi == heapArray[m].Deger)
                    {
                        kontrol = true;
                        break;
                    }
                }
            }
            return kontrol;
        }
        public void kisiSil(string kisiAd)
        {
            int m;
            for (m = 0; m < currentSize; m++)
            {
                if (heapArray[m] != null)
                {
                    if (kisiAd == heapArray[m].Deger.Ad)
                        break;
                }
            }
            Remove(m);
        }
    }
}