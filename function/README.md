# Function

Daftar isi:
- [Function](#function)
  - [Praktik: Membuat Script Baru (Latihan3.cs)](#praktik-membuat-script-baru-latihan3cs)
  - [Praktik: Function](#praktik-function)
  - [Praktik: Comment di Function dan Parameter](#praktik-comment-di-function-dan-parameter)
  - [Kredit](#kredit)

Di dalam pemrograman, function juga digunakan untuk memudahkan kita untuk memahami sekumpulan kode. Apabila menggunakan function, kode akan lebih sederhana dan rapi jika diimplementasikan dengan baik.

Aturan Penulisan Function/Method: 
- Setiap kata diawali dengan Huruf Besar. Misal:
    ```csharp 
    Tambahkan();
    ```
- Jika Nama fungsi lebih dari 2 kata maka kata kedua menggunakan huruf besar. Misal:
    ```csharp 
    SamaDengan();
    ```

## Praktik: Membuat Script Baru (Latihan3.cs)
Untuk memudahkan pembelajaran, buat script baru dengan nama *Latihan3*.cs. Langkah-langkahnya sebagai berikut:
1. Buat `C# Script` baru dengan klik kanan pada jendela Project > `Create` > `C# Script` > Langsung beri nama *Latihan3*.
2. Drag script *Latihan3*.cs ke GameObject `Main Camera` di jendela Hierarchy. Tujuannya adalah agar `Main Camera` menjalankan Script *Latihan3*.cs saat `Play Mode`.
3. Klik GameObject `Main Camera` di `Hierarchy`, Kemudian lihat jendela `Inspector`. Lalu hilangkan centang pada script *Latihan2.cs* Dengan ini, `Main Camera` hanya menjalankan script *Latihan3*, namun tidak *Latihan2*.

## Praktik: Function
Kemudian kita akan mengimplementasikan function pada *Latihan3.cs*.
Langkah-langkahnya sebagai berikut:
1. Buka Script *Latihan3*.cs. Tambahkan function di dalam class *Latihan3* sebagai berikut:
   ```csharp 
    int Jumlah(int a, int b)
    {
        return a + b;
    }
    ```
2. Tambahkan code ini di dalam function `Start()`
    ```csharp 
    int c = Jumlah(60, 40);
    Debug.Log("Hasil Jumlah a dan b adalah " + c);
    ```
3. Kemudian simpan perubahan code dengan klik Ctrl+S
Sehingga pada Script *Latihan3*.cs sebagai berikut:
```csharp 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class *Latihan3* : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        int c = Jumlah(60, 40);
        Debug.Log("Hasil Jumlah a dan b adalah " + c);
    }

    // Update is called once per frame
    void Update()
    {

    }

    int Jumlah(int a, int b)
    {
        return a + b;
    }
}
```

## Praktik: Comment di Function dan Parameter
Berfungsi untuk memberi informasi tentang function yang telah dibuat
1. Ketik `/` sebanyak 3 kali diatas fungsi `Jumlah()` kemudian akan muncul template comment seperti di bawah ini:
    ```csharp
    /// <summary>
    /// Jumlah the specified a and b.
    /// <summary>
    /// <param name="a">The alpha component.</param>
    /// <param name="b">The blue component.</param>
    int Jumlah(int a, int b) {
        return a + b;
    }
    ```
    Fitur di atas hanya dapat dilakukan di Editor MonoDevelop dan Visual Studio.
2. Pada Summary, tambahkan informasi tentang kegunaan fungsi tersebut. Kemudian pada parameter, tambahkan informasi tentang masing-masing parameter. Sehingga hasinya sebagai berikut:
   ```csharp
    /// <summary>
    /// Merupakan fungsi penjumlahan 2 input angka
    /// <summary>
    /// <param name="a">Masukkan angka Integer</param>
    /// <param name="b">Masukkan angka Integer</param>
    int Jumlah(int a, int b) {
        return a + b;
    }
    ```
3. Coba lakukan dengan memanggil ulang function tersebut di dalam fungsi `Start()`, maka informasi yang telah dimasukkan akan muncul. Comment ini akan sangat membantu jika kode yang kita tulis kompleks yang karenanya kita biasa memerlukan catatan di fungsi tersebut.

## Kredit
[Dicoding Indonesia](https://www.dicoding.com/)