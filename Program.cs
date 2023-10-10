namespace algoritma_sorulari;

class Program
{
    static void Main(string[] args)
    {
        //soru 1

        /*Console.WriteLine("bir sayi girin:");
        int sayi;
        sayi = int.Parse(Console.ReadLine());
        Console.WriteLine(sayi + " adet pozitif sayi girin.");
        int[] sayiDizisi = new int[sayi];
        int input;
        for(int i = 0 ; i < sayi ; i++){
            input = int.Parse(Console.ReadLine());
            if(input < 1){
                Console.WriteLine("girdiginiz sayi formata uymuyor");
                i--;
                continue;
            }
            sayiDizisi[i] = input;
        }
        Console.WriteLine("cift sayilar ****");
        foreach(int sayilar in sayiDizisi){
            if(sayilar % 2 ==0)
            Console.WriteLine(sayilar);

        }*/

        //soru 2

        /*int n,m;
        Console.WriteLine("n degerini gir.");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("m degerini gir");
        m = int.Parse(Console.ReadLine());

        Console.WriteLine(n + " adet pozitif sayi girin.");
        int[] sayiDizisi = new int[n];
        int input;
        for(int i = 0 ; i < n ; i++){
            input = int.Parse(Console.ReadLine());
            if(input < 1){
                Console.WriteLine("girdiginiz sayi formata uymuyor");
                i--;
                continue;
            }
            sayiDizisi[i] = input;
        }

        Console.WriteLine("m'e tam bolunen sayilar ****");
        foreach(int sayilar in sayiDizisi){
            if(sayilar % m ==0)
            Console.WriteLine(sayilar);

        }*/

        //soru3

        /*Console.WriteLine("pozitif sayi gir");
        int input;
        while(true){
            input = int.Parse(Console.ReadLine());
            if(input > 0){
                break;
            }
            Console.WriteLine("pozitif sayi gir");
        }

        string[] kelimeler = new string[input];

        for(int i = 0 ; i < input;i++){
            kelimeler[i] = Console.ReadLine();
        }

        foreach(string kelime in kelimeler.Reverse()){
            Console.WriteLine(kelime);
        }*/

        //soru4

        Console.WriteLine("bir cümle gir");
        string cumle;
        cumle = Console.ReadLine();
        string[] strlist = cumle.Split(" ");
        int kelimeSayisi=0;
        int harfSayisi=0;
        foreach (var item in strlist)
        {
            kelimeSayisi++;
            foreach (var harf in item)
            {
                harfSayisi++;
            }
        }
        Console.WriteLine(kelimeSayisi+" kelime sayisi");
        Console.WriteLine(harfSayisi + " harf sayisi");




        
        


    }
}
