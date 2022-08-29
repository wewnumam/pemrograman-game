# Inheritance

Daftar isi:
- [Inheritance](#inheritance)
  - [Inheritance](#inheritance-1)
  - [Praktik: Membuat Kelas Base](#praktik-membuat-kelas-base)
  - [Praktik: Membuat Kelas Turunan](#praktik-membuat-kelas-turunan)
  - [Kredit](#kredit)

## Inheritance

Inheritance atau warisan adalah konsep Pemrograman Berorientasi Objek (OOP) yang digunakan untuk mengakses dan menggunakan kembali sifat atau metode satu kelas dari kelas lainnya. 

Di dalam inheritance, kelas dasarnya dikenal sebagai Base Class (kelas dasar). Sementara kelas yang mewarisi dari base dikenal sebagai Derived Class (kelas turunan). 

Ketika membuat kelas baru di Unity, maka secara otomatis kelas tersebut merupakan turunan dari *MonoBehaviour* sebagai default-nya. Di dalam kelas turunan ini kita bisa mengakses banyak fungsi seperti `Update()`, `Start()`, dan fungsi lain yang dimiliki oleh Class *MonoBehaviour*.

```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kosongan : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
```

Kemudian ada 3 access modifier untuk menentukan apa saja function yang dapat diturunkan atau tidak dengan sebagai berikut:
1. **Public**, merupakan feature pada method, property atau variable yang dapat diturunkan kepada kelas yang diwariskan dan dapat diakses juga oleh kelas yang bukan turunannya.
2. **Protected**, murupakan feature pada method, property atau variable yang dapat diturunkan kepada kelas yang diwariskan tetapi tidak dapat diakses oleh kelas yang bukan turunannya.
3. **Private**, murupakan feature pada method, property atau variable yang tidak dapat diturunkan kepada kelas yang diwariskan tetapi tidak dapat diakses oleh kelas yang bukan turunannya.

## Praktik: Membuat Kelas Base
Kemudian kita akan membuat sebuah kelas dengan nama Manusia
1. Buatlah Folder dengan nama *Latihan5* agar script di submodule ini tertata rapi.
2. Buka folder *Latihan5*, kemudian buat script baru dengan nama *Manusia* (Klik Kanan > `Create` > `C# Script` > Beri nama *Manusia*)
3. Buka script *Manusia.cs* dengan klik 2 kali dan tambahkan kode di dalam Kelas *Manusia* di bawah ini:
    ```csharp
    public void Makan(){
        Debug.Log ("Perlu Makan");
    }
    public void Tidur(){
        Debug.Log ("Perlu Tidur");
    }
    ```
    Kemudian simpan perubahan dengan tekan `Ctrl+S`

    Sehingga tampak sebagai berikut:
    ```csharp
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Manusia : MonoBehaviour
    {
        public void Makan()
        {
            Debug.Log("Perlu Makan");
        }
        
        public void Tidur()
        {
            Debug.Log("Perlu Tidur");
        }
    }
    ```

## Praktik: Membuat Kelas Turunan
Selanjutnya membuat Kelas Turunan untuk mengimplementasikan Kelas *Manusia* sebagai kelas Base.
1. Buka Folder Latihan5, kemudian buat script baru dengan nama *Prajurit* (Klik Kanan > `Create` > `C# Script` > Beri nama *Prajurit.cs*)
2. Sesuaikan dengan code di bawah ini:
- Ganti kelas turunan dari *MonoBehaviour* menjadi *Manusia*
    ```csharp
    public class Prajurit : Manusia
    ```
- Tambahkan method ini di dalam kelas *Prajurit*
    ```csharp
    void Menyerang(){
        Debug.Log("Menyerang");
    }
    ```
- Tambahkan kode ini di dalam method `Start()`
    ```csharp
    Debug.Log("Seorang Prajurit dapat : ");
    Makan();
    Tidur();
    Menyerang();
    ```
- Kemudian Simpan perubahan dengan tekan `Ctrl+S`

    Sehingga seluruhnya seperti berikut:
    ```csharp
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Prajurit : Manusia
    {
        void Start()
        {
            Debug.Log("Seorang Prajurit dapat : ");
            Makan();
            Tidur();
            Menyerang();
        }

        void Update()
        {

        }

        void Menyerang()
        {
            Debug.Log("Menyerang");
        }
    }
    ```
3. Drag and Drop Script *Prajurit.cs* ke GameObject `Main Camera` di `Hierarchy`
4. Hilangkan centang pada script *Latihan*. Ketika dijalankan Prajurit selain dapat mengakses `Menyerang()`, juga memiliki sifat *Manusia* seperti `Makan()` dan `Tidur()`;

## Kredit
[Dicoding Indonesia](https://www.dicoding.com/)