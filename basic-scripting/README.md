# Basic Scripting

## Praktik: Membuat Project Baru
Kita bersiap membuat sebuah proyek baru yang akan digunakan di pembelajaran ini. Buka Unity, Kemudian klik New, lalu atur seperti di bawah ini:
1. Project name: BasicScripting
2. Mode: `2D`
3. Tentukan lokasi project yang akan disimpan
4. Klik `Create project`

## Praktik: Membuat Script
Untuk menampilkan text di Console, kita memerlukan sebuah script. langkah- langkah sebagai berikut:
1. Membuat Script baru dengan klik kanan pada `Jendela Project `> `Create` > `C# Script`, kemudian langsung beri nama “Latihan1”
2. Klik 2x script *Latihan1.cs*
3. Kemudian muncul script *Latihan1.cs* di Editor Script MonoDevelop
    ```csharp
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Latihan1 : MonoBehaviour 
    {
        // Use this for initialization
        void Start () {

        }

        // Update is called once per frame
        void Update () {

        }
    }
    ```

    Secara default, pada script yang baru dibuat akan ditampilkan 2 buah prosedur, yaitu:
    Fungsi | Penjelasan
    --- | ---
    `Start()` | Prosedur ini akan dipanggil satu kali di awal, pada saat script pertama kali di-enable. Prosedur ini sesuai untuk inisialisasi.
    `Update()` | Prosedur ini dipanggil pada setiap frame, apabila script di-enable. Prosedur ini sesuai untuk bagian script yang dieksekusi berulang-ulang.

    Untuk daftar prosedur dan fungsi lengkap yang ada pada kelas MonoBehaviour, silakan lihat pada link: https://docs.unity3d.com/ScriptReference/MonoBehaviour.html.
4. Menambahkan/mengubah code di Script Latihan1.cs
    - Tambahkan kode ini di dalam method `Start()`
    `Debug.Log("Hello World!");`
    - Simpan perubahan pada script dengan tekan `Ctrl+S `
  
    Sehingga tampil sebagai berikut:
    ```csharp
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Latihan1 : MonoBehaviour
    {
        // Use this for initialization
        void Start()
        {
            Debug.Log("Hello World!");
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
    ```

Pembahasan Code:
```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
```
Library di atas merupakan Library yang digunakan dalam perintah dalam script. Seperti penggunaan variable GameObject, Monobehavior, dll.
```csharp
public class Latihan1
```
Nama kelas dari sebuah script. Nama Kelas harus sama dengan nama file `C# Script` di folder *Assets*.
```csharp
void Start()
```
Fungsi di atas hanya dijalankan satu kali dan diawal saat program dijalankan
```csharp
Debug.Log("Hello World!");
```
`Debug.Log` digunakan untuk menghasilkan output di `Jendela Console` berupa text atau angka.
```csharp
void Update()
```
Dijalankan berulang-ulang setelah menjalankan function `Start()`.

## Praktik: Menjalankan Script
1. Drag n Drop Script *Latihan1.cs* ke GameObject *Main Camera* di
jendela `Hierarchy`.
2. Klik icon `Play` pada Unity.
3. Jika di klik Info tersebut maka akan muncul `Jendela Console`. Sebagai berikut: Jika Anda klik salah satu list yang terdapat di `Console`, akan muncul info detail dari informasi nama berkas (file) script sampai baris kode tersebut. Anda dapat menghilangkan info tersebut dengan klik tombol `Clear`.
4. Untuk mematikan Play Mode, dengan klik lagi pada icon Play.
5. Anda dapat simpan dengan klik menu `File` > `Save Scenes` atau tekan `Ctrl+S`. Kemudian beri nama *Main.unity*.