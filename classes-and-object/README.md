# Classes and Object

Daftar isi:
- [Classes and Object](#classes-and-object)
  - [Classes and Object](#classes-and-object-1)
  - [Praktik: Membuat Class Baru Karakter](#praktik-membuat-class-baru-karakter)
  - [Praktik: Mengimplementasikan Class Karakter Sebagai Object](#praktik-mengimplementasikan-class-karakter-sebagai-object)
  - [Kredit](#kredit)

## Classes and Object
Class adalah sebuah bangunan dasar dari bahasa berorientasi object. Ia berisi metode dan variabel yang berfungsi untuk menciptakan suatu instance dari object. Sedangkan object itu sendiri adalah perumpamaan dari class yang mempresentasikan sebuah object.

## Praktik: Membuat Class Baru Karakter
Kemudian kita akan membuat sebuah class dengan nama Karakter di dalam Folder *Latihan4*
1. Buatlah Folder dengan nama *Latihan4* agar script di submodul ini tertata rapi. Supaya script di submodul ini lebih rapi, buat dan kumpulkan scripts ke dalam 1 Folder.
2. Buka Folder *Latihan4*, kemudian buat script baru dengan nama Karakter (`Klik Kanan` > `Create` > `C# Script`).
3.  Buka script *Karakter.cs* dan ubah seluruh isi di dalam kelas *Karakter* seperti di bawah ini. 
    ```csharp
    using UnityEngine;
    public class Karakter{
        
    }
    ```

- Setiap script C#, pada bagian atas selalu diawali dengan nama Class. Penggunaan access control class tersebut menggunakan public class supaya ia dapat dipanggil di class lain untuk dijadikan sebagai object. Selanjutnya, kita menghilangkan turunan dari *MonoBehavior*. Kenapa? Karena pada Class ini tidak membutuhkan fungsi yang terdapat di dalam *MonoBehavior* Tambahkan attribute di dalam class Karakter sebagai berikut:
    ```csharp
    private string name;
    private int health;
    private int damage;

    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }

    public int Health
    {
        get
        {
            return health;
        }

        set
        {
            health = value;
        }
    }

    public int Damage
    {
        get
        {
            return damage;
        }

        set
        {
            damage = value;
        }
    }
    ```

    Tambahkan method sebagai berikut:
    ```csharp
    public void MoveLeft()
    {
        Debug.Log("Gerak ke kiri");
    }

    public void MoveRight()
    {
        Debug.Log("Gerak ke kekanan");
    }

    public void Jump()
    {
        Debug.Log("Loncat");
    }

    public void Attack()
    {
        Debug.Log("Serang");
    }
    ```
- Simpan perubahan pada script dengan tekan `Ctrl+S`.

Sehingga pada script *Karakter.cs* sebagai berikut:
```csharp
using UnityEngine;

public class Karakter
{
    private string name;
    private int health;
    private int damage;

    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }
    public int Health
    {
        get
        {
            return health;
        }

        set
        {
            health = value;
        }
    }
    
    public int Damage
    {
        get
        {
            return damage;
        }

        set
        {
            damage = value;
        }
    }
}

public void MoveLeft()
{
    Debug.Log("Gerak ke kiri");
}

public void MoveRight()
{
    Debug.Log("Gerak ke kekanan");
}

public void Jump()
{
    Debug.Log("Loncat");
}

public void Attack()
{
    Debug.Log("Serang");
}
```

## Praktik: Mengimplementasikan Class Karakter Sebagai Object
Ayo kita membuat kelas baru yang nantinya akan memanggil class `Karakter` sebagai object.
1. Buka Folder *Latihan4* kemudian Klik Kanan pada jendela Project > `Create` > `C# Script` > Beri nama *Latihan4.cs*
2. Buka script *Latihan4.cs* dengan klik 2 kali kemudian tambahkan kode di bawah ini:
- Menambahkan variable dari Kelas `Karakter` di dalam Kelas *Latihan4*
    ```csharp
    Karakter player1;
    ```
- Menginisialisasi player1 didalam function `Start()`
    ```csharp
    player1 = new Karakter ();
    player1.Name = "Dico";
    player1.Health = 100;
    player1.Damage = 30;

    // Menampilkan hasil dari inisialisasi attribute
    Debug.Log ("Name: "+player1.Name+", Health: "+player1.Health+", Damage: "+player1.Damage);
    
    // Memanggil method dari salah satu method di class Karakter.
    player1.Jump ();
    ```
- Simpan perubahan script dengan tekan `Ctrl+S`

Sehingga pada script *PlayerController.c*s sebagai berikut:
```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Latihan4 : MonoBehaviour
{
    Karakter player1;

    // Use this for initialization
    void Start()
    {
        player1 = new Karakter();
        player1.Name = "Dico";
        player1.Health = 100;
        player1.Damage = 30;
        
        // Menampilkan hasil dari inisialisasi attribute
        Debug.Log("Name: " + player1.Name + ", Health: " + player1.Health + ", Damage: " + player1.Damage);
        
        // Memanggil method dari salah satu method di class Karakter.
        player1.Jump();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
```

Drag and Drop script *Latihan4.cs* ke GameObject Main Camera di `Hierarchy` Hilangkan centang pada `Latihan 3`. Jendela Console menampilkan log informasi dari Attribute function dan dari function `Jump()`.

## Kredit
[Dicoding Indonesia](https://www.dicoding.com/)