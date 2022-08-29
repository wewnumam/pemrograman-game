# MonoBehavior

*MonoBehaviour* adalah class dasar dari setiap script Unity yang dibuat. Ketika Anda menggunakan C#, *MonoBehaviour* secara otomatis (default) akan tercipta. Letaknya ada pada tab `Inspector`. Fungsi *MonoBehaviour* untuk menonaktifkan script ketika di tidak di-checklist. Jika fungsi-fungsi tersebut dinonaktifkan maka tidak akan terjadi apa-apa pada Log `Console`.

Daftar isi:
- [MonoBehavior](#monobehavior)
  - [Awake](#awake)
  - [Start](#start)
  - [Update](#update)
  - [FixedUpdate](#fixedupdate)
  - [LateUpdate](#lateupdate)
  - [Kredit](#kredit)

Di bawah ini adalah diagram untuk pengurutan dan pengulangan fungsi selama script dijalankan.
![Script lifecycle flowchart](https://docs.unity3d.com/uploads/Main/monobehaviour_flowchart.svg)

## Awake
*Awake* digunakan untuk menginisialisasi variabel pada saat status game belum dimulai. *Awake* dipanggil ketika script sedang dijalankan dan setelah semua objek diinisialisasi Sehingga, Anda dapat memanggil objek lain. 

Contoh kode dari fungsi *Awake*:
```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LatihanAwake : MonoBehaviour {
    void Awake() {
        Debug.Log("Awake Dipanggil");
    }
}
```

Pembahasan kode:
```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
```
3 baris kode di atas adalah Library bawaan saat script dibuat. Kita dapat memberi Library tambahan seperti scene, UI dan lainnya.
```csharp
public class LatihanAwake: MonoBehaviour
```
Nama kelas dari script. Nama kelas harus sama dengan berkas (file) script yang dibuat.
```csharp
void Awake()
```
Fungsi ini akan dipanggil selama script dijalankan.
```csharp
Debug.Log("Awake Dipanggil");
```
Akan terpanggil setelah fungsi `Awake()` dijalankan.

## Start
*Start* dipanggil ketika script diaktifkan tepat sebelum fungsi *Update* dipanggil pertama kali. Seperti fungsi *Awake*, *Start* dipanggil tepat saat script dalam keadaan aktif. Namun, *Awake* dipanggil ketika objek script di nisialisasi, terlepas dari apakah script diaktifkan atau tidak.

Contoh kode dari fungsi *Start*:
```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LatihanStart : MonoBehaviour {
    void Start() {
        Debug.Log("Start Dipanggil");
    }
}
```

Pembahasan kode:
```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
```
3 baris kode di atas adalah Library bawaan saat script dibuat. Kita dapat memberi Library tambahan seperti scene, UI dan lainnya.
```csharp
public class LatihanStart : MonoBehaviour
```
Nama kelas dari script. Nama kelas harus sama dengan berkas script yang dibuat.
```csharp
void Start()
```
Fungsi ini akan dipanggil saat script diaktifkan dan dijalankan.
```csharp
Debug.Log("Start Dipanggil");
```
Akan terpanggil setelah fungsi `Start()` dijalankan. Berikut ini contoh penerapan kedua fungsi tersebut, *Awake* dan *Start*.
```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan1 : MonoBehaviour {
    //fungsi Awake
    void Awake() {
        Debug.Log("Awake dipanggil");
    }

    //fungsi Start
    void Start() {
        Debug.Log("Start dipanggil");
    }
}
```

## Update
*Update* akan aktif jika *MonoBehaviour* diaktifkan. *Update* akan terpanggil sesudah Start dipanggil. *Update* adalah fungsi yang paling sering digunakan untuk menerapkan script game. Namun, tidak semua MonoBehaviour membutuhkan script *Update*. Biasanya kita membuat method baru untuk mendeklarasikan sebuah fungsi.

Contoh kode dari fungsi *Update*:
```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LatihanUpdate : MonoBehaviour {
    void Update() {
        Debug.Log("Waktu untuk Update :" + Time.deltaTime);
    }
}
```

Pembahasan kode:
```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
```
3 baris kode di atas adalah Library bawaan saat script dibuat. Kita dapat memberi Library tambahan seperti scene, UI dan lainnya.
```csharp 
public class LatihanUpdate : MonoBehaviour
```
Nama kelas dari script. Nama kelas harus sama dengan berkas script yang dibuat.
```csharp 
void Update()
```
Fungsi ini akan dipanggil saat script diaktifkan dan dijalankan setelah `Start()`.
```csharp 
Debug.Log("Waktu untuk Update :" + Time.deltaTime);
```
Dijalankan saat fungsi `Update()` dijalankan dan akan menampilkan waktu yang sama.

## FixedUpdate
*FixedUpdate* biasanya digunakan sebagai gantinya Update ketika bertemu dengan Rigidbody. Misalnya saat menambahkan physic ke benda.

Contoh kode dari fungsi *FixedUpdate*:
```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LatihanFixedUpdate : MonoBehaviour {
    void FixedUpdate() {
        Debug.Log("Waktu untuk FixedUpdate :" + Time.deltaTime);
    }
}
```

Pembahasan kode:
```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
```
3 baris kode di atas adalah Library bawaan saat script dibuat. Kita dapat memberi Library tambahan seperti scene, UI dan lainnya.
```csharp
public class LatihanFixedUpdate : MonoBehaviour
```
Nama kelas dari script. Nama kelas harus sama dengan berkas script yang dibuat.
```csharp
void FixedUpdate()
```
Fungsi ini akan dipanggil saat script diaktifkan dan dijalankan setelah `Update()`.
```csharp
Debug.Log("Waktu untuk FixedUpdate :" + Time.deltaTime);
```
Dijalankan saat fungsi `FixedUpdate()` dijalankan dan akan menampilkan waktu berbeda.

## LateUpdate
*LateUpdate* dipanggil setelah semua fungsi *Update* dipanggil. Ia berguna untuk memberi log console eksekusi script. Contohnya, *Camera Follow* harus selalu diimplementasikan di *LateUpdate* karena melacak objek yang mungkin telah bergerak di dalam Update.

Contoh kode dari fungsi *LateUpdate*:
```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LatihanLateUpdate : MonoBehaviour {
    void LateUpdate() {
        Debug.Log("Waktu untuk LateUpdate :" + Time.deltaTime);
    }
}
```

Pembahasan kode:
```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
```
3 baris kode di atas adalah Library bawaan saat script dibuat. Kita dapat memberi Library tambahan seperti scene, UI dan lainnya.
```csharp
public class LatihanLateUpdate : MonoBehaviour
```
Nama kelas dari script. Nama kelas harus sama dengan berkas script yang dibuat.
```csharp
void LateUpdate()
```
Fungsi ini akan dipanggil saat script diaktifkan dan dijalankan setelah `Update()` dan `FixedUpdate()`.
```csharp
Debug.Log("Waktu untuk LateUpdate :" + Time.deltaTime);
```
Dijalankan saat fungsi `LateUpdate()` dijalankan dan akan menampilkan waktu berbeda.

Berikut ini contoh penerapan ketiga fungsi *Update*, *FixedUpdate* dan *LateUpdate*.
```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan1 : MonoBehaviour {
    void FixedUpdate () {
        Debug.Log("Waktu untuk FixedUpdate :" + Time.deltaTime);
    }

    void Update () {
        Debug.Log("Waktu untuk Update :" + Time.deltaTime);
    }

    void LateUpdate () {
        Debug.Log("Waktu untuk LateUpdate :" + Time.deltaTime);
    }
}
```

## Kredit
[Dicoding Indonesia](https://www.dicoding.com/)