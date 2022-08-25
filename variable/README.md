# Variable

Daftar isi:
- [Variable](#variable)
  - [Variable](#variable-1)
  - [Modifier Access](#modifier-access)
  - [Cara Deklarasi Variable](#cara-deklarasi-variable)
    - [Global Variable](#global-variable)
    - [Local Variable](#local-variable)
    - [Constant Variable](#constant-variable)
    - [Static Variable](#static-variable)
  - [Aturan Penulisan Nama Variable](#aturan-penulisan-nama-variable)
  - [Praktik: Membuat Script Baru (Latihan2.cs)](#praktik-membuat-script-baru-latihan2cs)
  - [Praktik: Variable Unity](#praktik-variable-unity)
  - [Praktik: Variable dan Inspector](#praktik-variable-dan-inspector)
  - [Praktik: Attribute Variable](#praktik-attribute-variable)
  - [Kredit](#kredit)

## Variable
Sebuah variable dapat menyimpan satu dari dua tipe nilai, yaitu value type dan references type.
- **Values Type** adalah dasar dari tipe data primitive seperti char, int, dan
float, serta tipe user-defined yang dideklarasikan dengan struct.
- **Reference Type** adalah kumpulan class atau data kompleks yang dibangun dari tipe data primitive.

Setiap Komponen pada GameObject adalah Merupakan Reference Type. Untuk mengetahui lebih detail tentang perbedaan antara value dan reference type, Anda bisa melihatnya di Data Types

## Modifier Access
Modifier Access merupakan hak akses user untuk memanggil sebuah variable dari sebuah kelas.

Modifier Access | Penjelasan
--- | ---
`public` | Variable yang dapat dipanggil/diakses dari kelas lain.
`protected` | Variable yang dapat dipanggil/diakses hanya dari kelas turunan.
`private` | Variable yang hanya dapat diakses oleh kelas itu sendiri.
Default | Variable tanpa modifier accsess, yang memiliki hak akses sama seperti `private`.

Contoh:
```csharp
public float speed;     // Public
protected int count;    // Protected
private Rigidbody rb;   // Private
float movementX;        // Default
```

## Cara Deklarasi Variable
Ada beberapa cara deklarasi variable yang sering digunakan dalam membuat Game. Cara tersebut dikelompokkan sebagai berikut:

### Global Variable
Variable yang dapat digunakan atau dipanggil oleh semua fungsi atau method. Misal:
```csharp
public class Contoh : MonoBehaviour {
    string nama = "Dico"; // Global Variable

    void Start() {
        Debug.Log ("My Name: " + nama); // Kamu dapat panggil di sini
    }

    void Update () {
        Debug.Log ("My Name: " + nama); // Kamu dapat panggil di sini
    }
}
```

### Local Variable
Variable yang hanya dipanggil pada method atau fungsi yang dimana variable tersebut dideklarasikan. Misal:
```csharp
public class Contoh : MonoBehaviour {

    void Start() {
        string nama = "Dico"; // Local Variable
        Debug.Log ("My Name: "+nama); // Kamu dapat panggil disini
    }

    void Update() {
        // Kamu tidak dapat panggil disini
    }
}
```

### Constant Variable
Variable yang memiliki nilai tetap dan tidak dapat diubah. Misal:
```csharp
public class Contoh : MonoBehaviour {
    const string ID = "1234"; // Constant Variable
}
```

### Static Variable
Variable yang dapat langsung dipanggil oleh kelas lain tanpa harus membuat object dari kelas itu sendiri. Misal:
Kelas yang terdapat variable static
```csharp
public class Data {
    public static string ID = "1234"; // Static Variable
}
```

Kelas yang memanggil variable static
```csharp
public class Contoh : MonoBehaviour {
    void Start() {
        Debug.Log("ID: " + Data.ID); // Kamu dapat panggil disini
    }
}
```

## Aturan Penulisan Nama Variable
Penulisan nama variable sebenarnya bebas, tetapi untuk membedakan penulisan yang lain (kelas dan fungsi) maka membutuhkan penulisan khusus:
- Kata diawali huruf kecil Misal: **timer**, **nama**, **alamat**.
- Jika lebih dari 2 kata, maka Kata kedua diawali huruf besar. Misal: *playerController*, *enemyZombie*.

Tetapi hal diatas tidak berlaku pada variable Konstanta. Untuk Variable Konstanta memiliki aturan sebagai berikut:
- Semua huruf pada kata terdiri dari huruf besar. Misal: **TOKEN**
- Jika lebih dari 2 kata, maka dipisahkan dengan garis bawah (Underscore). Misal: **TOKEN_ADS**

## Praktik: Membuat Script Baru (Latihan2.cs)
Untuk memudahkan pembelajaran, buat script baru dengan nama Latihan2.cs
1. Buat C# Script baru dengan klik kanan pada jendela Project > `Create` > `C# Script` > Langsung beri nama *Latihan2*.
2. Drag Script *Latihan2.cs* ke GameObject `Main Camera` di Jendela `Hierarchy`.
3. Supaya Script *Latihan2.cs* dijalankan oleh `Main Camera` ketika menjalankan `Play Mode`. Klik GameObject `Main Camera` di `Hierarchy`, Kemudian Lihat Jendela `Inspector`. Lalu hilangkan centang padaScript *Latihan1.cs*. Sehingga script pada Latihan 1 tidak dijalankan dan `Main Camera` akan menjalankan script Latihan 2

## Praktik: Variable Unity
Pertama, kita mengimplementasi variable sederhana di Unity Buka Script *Latihan2.cs*. 

Tambahkan code ini didalam class `Latihan2`:
```csharp
int nilaiA = 5;
int nilaiB = 9;
```
Tambahkan code ini di dalam method `Start()`
```csharp
int totall = nilaiA + nilaiB;
Debug.Log("Total "+totall);
```

Simpan dengan `Ctrl+S`. Sehingga tampilannya sebagai berikut:
```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan2 : MonoBehaviour
{

    int nilaiA = 5;
    int nilaiB = 9;

    // Use this for initialization
    void Start()
    {
        int totall = nilaiA + nilaiB;
        Debug.Log("Total " + totall);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
```
Kemudian hasilnya sebagai berikut: Pada `Console` menunjukkan informasi bahwa nilai total dari nilai A dan nilai B
adalah 14.  

## Praktik: Variable dan Inspector
Kita dapat mengubah nilai variable `NilaiA` dan `NilaiB` lewat jendela Inspector dan tanpa harus mengubah nilai variable tersebut di script. Caranya kita menggunakan variable public untuk memunculkan field di `Inspector`. Detailnya sebagai berikut:

Ubahlah pada code
```csharp
int nilaiA = 5;
int nilaiB = 9;
```

Menjadi
```csharp
public int nilaiA;
public int nilaiB;
```
Kemudian simpan perubahan dengan tekan `Ctrl+S`.

Sehingga menjadi sebagai berikut:
```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan2 : MonoBehaviour
{

    public int nilaiA;
    public int nilaiB;

    // Use this for initialization
    void Start()
    {
        int totall = nilaiA + nilaiB;
        Debug.Log("Total " + totall);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
```
Kembali ke Unity, Klik `Main Camera` dan kemudian lihat pada `Inspector`. Variable yang menggunakan modifier public akan muncul di `Inspector`. Lalu masukkan nilai dengan misal `NilaiA` = 12 dan `NilaiB` = 13.

## Praktik: Attribute Variable
1. Buka Script *Latihan2.cs*
2. Tambahkan code di bawah ini di dalam Class `Latihan2`
    - Tambahkan code ini di dalam class `Latihan2`
        ```csharp
        [Range(1,5)]
            public int nilaiC;
        ```
    - Ubah code yang terdapat di dalam function `Start()`
        ```csharp
        int totall = nilaiA + nilaiB;
        ```
    - Menjadi
        ```csharp
        int totall = (nilaiA + nilaiB) * nilaiC;
        ```
    - Simpan perubahan dengan tekan `Ctrl+S`

    Sehingga script pada *Latihan2* seperti berikut:
    ```csharp
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    
    public class Latihan2 : MonoBehaviour
    {
    
        public int nilaiA;
        public int nilaiB;
        [Range(1, 5)]
            public int nilaiC;
        
        // Use this for initialization
        void Start()
        {
            int totall = (nilaiA + nilaiB) * nilaiC;
            Debug.Log("Total " + totall);
        }
        
        // Update is called once per frame
        void Update()
        {
        
        }
    }
    ```
3. Kembali ke Unity, Klik `Main Camera` dan kemudian lihat pada `Inspector`. Lalu masukkan `NilaiC` = 4. Pada field `NilaiC`, hanya dapat diisi dari nilai 1 sampai nilai 5. Anda dapat mengganti nilai dengan menggeserkan slider atau langsung memasukkan nilai kedalam field. Anda dapat simpan yang telah Anda kerjakan di atas dengan klik menu `File` > `Save Scenes` atau tekan `Ctrl+S`.

## Kredit
[Dicoding Indonesia](https://www.dicoding.com/)