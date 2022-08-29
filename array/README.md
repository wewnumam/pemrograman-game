# Array

Daftar isi
- [Array](#array)
  - [Array](#array-1)
    - [Single Dimension Arrays](#single-dimension-arrays)
    - [Multi-Dimensional Arrays](#multi-dimensional-arrays)
    - [Jagged Arrays](#jagged-arrays)
  - [Praktik: Membuat Script Baru (*Latihan6.cs*)](#praktik-membuat-script-baru-latihan6cs)
  - [Praktik: Array dan `Inspector`](#praktik-array-dan-inspector)
  - [Kredit](#kredit)

## Array
Jika Anda terbiasa menggunakan bahasa Java, mungkin akan sedikit bingung dengan penulisan Array di C#. Perbedaannya Anda dapat pelajari di pembahasan ini. Array digunakan untuk menyimpan tipe data sejenis yang dikelompokkan sebagai satu kesatuan.

### Single Dimension Arrays
Menyimpan banyak nilai dalam satu variable. Misal:
```csharp
int[] intArray; // Deklarasi Array

void Start () {
    intArray = new int[4]; // Inisialisasi Array

    intArray[0] = 10; // Memasukkan nilai ke Array
    intArray[1] = 20;
    intArray[2] = 30;
    intArray[3] = 40;
}
```

### Multi-Dimensional Arrays
Berikut ini contoh array dengan 2 Dimensi. Untuk array 2 dimensi untuk mendapatkan sebuah nilai, maka diperlukan 2 buah nilai misal Baris ke 4 dan Kolom ke 3. Misal:
```csharp
int[,] intArray2; // Deklarasi Array

void Start () {
    intArray2 = new int[2,2]; // Inisialisasi Array

    intArray2[0,0] = 10;// Memasukkan nilai ke Array
    intArray2[1,0] = 30;
    intArray2[0,1] = 20;
    intArray2[1,1] = 40;
}
```

### Jagged Arrays
Bisa dikatakan array di dalam array. Misal:
```csharp
int[][] intArray3; // Deklarasi Array

void Start () {
    intArray3 = new int[2][]; // Inisialisasi Element

    intArray3[0] = new int[2]; // Inisialisasi Array
    intArray3[1] = new int[3];
    intArray3[0][0] = 10;// Memasukkan nilai ke Array
    intArray3[0][1] = 20;
    intArray3[1][0] = 30;
    intArray3[1][1] = 40;
    intArray3[1][2] = 50;
}
```

Untuk lebih detailnya dapat dilihat di sini:
https://docs.unity3d.com/ScriptReference/Array.html

## Praktik: Membuat Script Baru (*Latihan6.cs*)
Untuk memudahkan pembelajaran, buat script baru dengan nama *Latihan6.cs*
1. Buat C# Script baru dengan klik kanan pada jendela `Project` > `Create` > `C# Script `> Langsung beri nama *Latihan6*
2. Drag script *Latihan6.cs* ke GameObject ``Main Camera`` di Jendela HierarchySupaya script *Latihan6.cs* dijalankan oleh `Main Camera` ketika menjalankan `Play Mode`.
3. Klik GameObject `Main Camera` di `Hierarchy`, Kemudian Jendela `Inspector`. Lalu hilangkan centang pada script *Prajurit.cs* lihat Dengan ini, `Main Camera` akan menjalankan script *Latihan6*, bukan script *Prajurit*
4. Buka script *Latihan6* kemudian ubahlah script seperti dibawah ini:
- Tambahkan kode ini di dalam class *Latihan6*
    ```csharp
    int[] intArray; // Deklarasi Array
    ```
- Tambahkan kode ini di dalam function `Start()`
    ```csharp
    intArray = new int[4]; // Inisialisasi Array
    
    intArray[0] = 10; // Memasukkan nilai Array
    intArray[1] = 20;
    intArray[2] = 30;
    intArray[3] = 40;

    Debug.Log ("Menampilkan Seluruh Array");

    foreach (int a in intArray) {
        Debug.Log (a);
    }

    Debug.Log ("Nilai Index ke 2 adalah "+intArray[2]);
    ```

    Sehingga tampil sebagai berikut:
    ```csharp
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Latihan6 : MonoBehaviour
    {
        int[] intArray; // Deklarasi Array
        // Use this for initialization
        void Start()
        {
            intArray = new int[4]; // Inisialisasi Array
            
            intArray[0] = 10; // Memasukkan nilai Array
            intArray[1] = 20;
            intArray[2] = 30;
            intArray[3] = 40;
            
            Debug.Log("Menampilkan Seluruh Array");
            
            foreach (int a in intArray)
            {
                Debug.Log(a);
            }
            
            Debug.Log("Nilai Index ke 2 adalah " + intArray[2]);
        }
        
        // Update is called once per frame
        void Update()
        {
            
        }
    }
    ```

## Praktik: Array dan `Inspector`
Kita selain dapat menginisialisasi Array di dalam script, Kita juga dapat menginisialisasi Array di dalam `Inspector`.
1. Buka script *Latihan6.cs* dan ubah sebagai berikut:
   ```csharp
    int[] intArray;
    ```
    menjadi
    ```csharp
    public int[] intArray;
    ```
    Sehingga script pada *Latihan6.cs* sebagai berikut:
    ```csharp
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Latihan6 : MonoBehaviour
    {

        public int[] intArray; // Deklarasi Array

        // Use this for initialization
        void Start()
        {
            Debug.Log("Menampilkan Seluruh Array");

            foreach (int a in intArray) {
                Debug.Log(a);
            }
            
            Debug.Log("Nilai Index ke 2 adalah " + intArray[2]);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
    ```
2. Kembali ke Unity dan Klik GameObject `Main Camera`. Kemudian pada `Inspector`. klik icon panah pada field `IntArray`
3. Masukkkan Size 5 dan masukkan ke-5 angka tersebut. Simpan Project Anda dengan tekan `Ctrl+S` atau klik Menu `File` > pilih `Save Scenes`. Kemudian simpan dengan nama *Main.unity*

## Kredit
[Dicoding Indonesia](https://www.dicoding.com/)