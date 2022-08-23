# User Interface
UI atau User Interface memungkinkan Anda membuat antarmuka pengguna sebagai tampilan di dalam game. Dari tampilan tersebut, kita dapat membuatnya ke dalam berbagai macam bentuk, seperti kanvas, gambar, tombol, teks dan lainnya.

Daftar isi:
- [User Interface](#user-interface)
  - [Canvas](#canvas)
    - [Screen Space - Overlay](#screen-space---overlay)
    - [Screen Space - Camera](#screen-space---camera)
    - [World Space](#world-space)
  - [RectTransform](#recttransform)
  - [Panel](#panel)
  - [Image](#image)
  - [Raw Image](#raw-image)
  - [Mask](#mask)
  - [Button](#button)
  - [Event System](#event-system)
  - [Text](#text)
  - [Input Field](#input-field)
  - [Toogle](#toogle)
  - [Dropdown](#dropdown)
  - [Slider](#slider)
  - [Scrollbar](#scrollbar)
  - [Scroll View](#scroll-view)
  - [Kredit](#kredit)

## Canvas
Canvas adalah area di mana semua elemen UI harus ada di dalamnya. Canvas adalah parent sementara elemen UI adalah child. Kita dapat menambahkan Canvas dengan cara klik kanan pada `Hierarchy` > `UI` > `Canvas`. Saat kita membuat canvas baru, maka canvas tersebut akan menjadi parent dari elemen
UI.

Jika kita membuat elemen UI baru seperti tombol (button) dengan cara klik kanan pada `Hierarchy` > `UI` > `Button`, otomatis terciptalah canvas baru. Elemen UI (button) akan otomatis menjadi child pada canvas. Canvas memiliki pengaturan Render Mode yang dapat digunakan untuk ditampilkan
pada layar.

### Screen Space - Overlay
Mode render ini menempatkan elemen UI yang ditampilkan pada layar. Jika kita mengubah ukuran layar atau resolusi, canvas akan secara otomatis menyesuaikan ukuran agar selaras dengan keduanya.

### Screen Space - Camera
Screen Space - Camera juga mirip dengan Screen Space - Overlay, tetapi dalam mode render ini canvas ditempatkan pada jarak tertentu di depan kamera yang ditentukan. Kamera ini memberikan elemen UI yang berarti bahwa pengaturan Kamera akan mempengaruhi penampilan UI.

### World Space
Dalam mode render in, canvas akan menjadi objek lain di dalam layar. Ukuran canvas dapat diatur secara manual menggunakan Rect Transform dan elemen UI akan ditampilkan di depan atau di belakang objek lain dalam scene berdasarkan penempatannya.

## RectTransform
RectTransform adalah tata letak untuk mengatur bentuk objek 2D dari komponen transform. Transform merepresentasikan satu titik dan Rect Transform merepresentasikan persegi panjang di mana elemen UI dapat ditempatkan di dalamnya. Jika Rect Transform memiliki parent dan child, maka child berada di dalam parent. Child Rect Transform dapat menentukan posisi dan ukuran yang relatif terhadap persegi panjang parent Rect Transform.

Berikut ini penjelasan fungsi masing-masing:
Fungsi | Penjelasan
--- | ---
**Pos (X, Y, Z)** | Posisi pivot point persegi panjang pada anchor.
**Width/Height** | Lebar dan tinggi persegi panjang.
**Anchor** | Titik anchor untuk sudut kiri bawah dan sudut kanan atas persegi panjang.
**Min** | Titik anchor untuk sudut kiri bawah persegi panjang didefinisikan sebagai pecahan dari ukuran persegi panjang parent. Posisi 0,0 merepresentasikan sudut kiri bawah dari parent, sementara 1,1 berhubungan dengan sudut kanan atas dari parent.
**Max** | Titik anchor untuk sudut kanan atas persegi panjang didefinisikan sebagai pecahan ukuran persegi panjang parent. 0,0 merepresentasikan sudut kiri bawah dari parent, sementara 1,1 berhubungan dengan sudut kanan atas dari parent.
**Pivot** | Pivot point yang bentuknya bulat berwarna biru pada persegi panjang, yang didefinisikan sebagai pecahan ukuran persegi panjang itu sendiri. 0,0 sesuai dengan sudut kiri bawah sementara 1,1 sesuai dengan sudut kanan atas.
**Rotation** | Sudut rotasi dari objek di sekitar titik pivot, mempunya sumbu X, Y, dan Z.
**Scale** | Skala diterapkan pada objek dalam dimensi X, Y, dan Z.

## Panel
Panel adalah adalah tempat untuk menyusun komponen GameObject secara grup. Kita dapat memanfaatkan Panel ini untuk membuat validasi, grouping komponen UI dan lainnya. Panel hampir serupa dengan Image, namun Panel secara default memiliki sumber gambar (source image) yang berupa Background. Kita dapat menambahkan Panel dengan cara klik kanan pada `Hierarchy` > `UI` > `Panel`.

Berikut ini penjelasan fungsi masing-masing:
Fungsi | Penjelasan
--- | ---
**Source Image** | Tekstur yang mewakili gambar untuk ditampilkan (yang harus diimpor sebagai Sprite).
**Color** | Warna untuk diterapkan pada gambar.
**Material** | Bahan yang digunakan untuk rendering gambar.
**Raycast Target** | Target untuk raycasting.

## Image
Image adalah sebuah gambar yang tampil pada layar pengguna. Image dapat digunakan untuk hiasan, ikon, dan lainnya. Image dapat berasal dari script. Image di sini juga mirip dengan gambar mentah (raw image) yang bisa kita ubah posisi, ukuran, dan lainnya. Kita juga dapat mengubahnya menjadi gambar animasi yang bergerak.

Dengan tekstur, kita bisa mengubah baik image maupun raw image menjadi sprite (gambar UI 2D). Bedanya, jika image membutuhkan tekstur 2D, raw image apat menerima tekstur apapun. Kita dapat menambahkan Image dengan cara klik kanan pada `Hierarchy` > `UI` > `Image`.

Berikut ini penjelasan fungsi masing-masing:
Fungsi | Penjelasan
--- | ---
**Source Image** | Tekstur yang mewakili image untuk ditampilkan (yang harus diimpor sebagai Sprite).
**Color** | Warna untuk diterapkan pada image.
**Material** | Bahan yang digunakan untuk rendering image.
**Raycast Target** | Target untuk raycasting.

Berikut ini adalah contoh implementasi script untuk Image menggunakan Sprite yang dapat dilihat dan diubah pada Inspector sebagai bagian dari komponen gambar. Sprite juga dapat diubah menggunakan script. Berikut contoh kodenya.
```csharp
using UnityEngine;
using UnityEngine.UI;

public class Images : MonoBehaviour {
    Image m_Image;

    // Atur pada Inspector
    public Sprite m_Sprite;


    void Start() {
        // Ambil Gambar dari GameObject
        m_Image = GetComponent<Image>();
    }


    void Update() {
        // Tekan spasi untuk mengubah Sprite dari Gambar
        if (Input.GetKey(KeyCode.Space)) {
            m_Image.sprite = m_Sprite;
        }
    }
}
```

## Raw Image
Raw Image adalah gambar non-interaktif untuk hiasan, ikon, dan lainnya. Sementara image adalah gambar yang biasa digunakan untuk Sprite, Background dan lainnya. Raw Image dan Image hampir sama penggunaannya. Kita dapat menambahkan Raw Image dengan cara klik kanan pada `Hierarchy` > `UI` > `Raw` Image.

Berikut ini penjelasan fungsi masing-masing:
Fungsi | Penjelasan
--- | ---
**Texture** |  Tekstur yang mewakili gambar untuk ditampilkan.
**Color** |  Warna untuk diterapkan pada gambar.
**Material** |  Bahan yang digunakan untuk rendering gambar.
**Raycast Target** |  Target untuk raycasting.
**UV Rect** |  Offset dan ukuran gambar dalam mengontrol persegi panjang. Kita memberikan UV Rect dalam koordinat yang dinormalkan (rentang 0,0 hingga 1,0). Kita merentangkan tepi-tepi gambar untuk mengisi ruang di sekitaran persegi panjang UV.

Berikut ini adalah contoh implementasi script untuk Raw Image, yang digunakan untuk mengubah atau mengembalikan tampilan Texture Raw Image. Raw Image dapat menampilkan Tekstur (texture) apapun, sedangkan komponen Image hanya dapat menampilkan Tekstur Sprite, berikut contoh kodenya.

```csharp
using UnityEngine;
using UnityEngine.UI;

public class RawImages : MonoBehaviour {
    RawImage m_RawImage;

    // Pilih Tekstur pada Inspector untuk diubah menjadi gambar
    public Texture m_Texture;

    void Start() {
        // Ambil komponen Raw Image dari GameObject
        m_RawImage = GetComponent<RawImage>();

        // Ubah Tekstur yang Anda tentukan di Inspector
        m_RawImage.texture = m_Texture;
    }
}
```

## Mask
Mask bukanlah UI yang terlihat, melainkan cara memodifikasi tampilan elemen turunan dari child. Mask membatasi (yaitu, "mask") elemen child ke bentuk parent. Jadi, jika child lebih besar dari parent, maka hanya bagian child yang cocok dalam parent. Sebelum menambahkan Mask pada Inspector, kita tambahkan GameObject Image terlebih dahulu pad Hierarchy dengan cara klik kanan pada `Hierarchy` > `UI` > `Image`.

Kita dapat menyusun Mask yang telah dibuat dengan cara menambahkan dua GameObject yaitu Image dan Panel. dan Panel adalah Background yang Yang mana Image adalah dijadikan Mask. Kita dapat gambar merubah bentuk Mask yang diinginkan dengan cara seperti ini.

## Button
Button adalah sebuah tombol yang merespon klik dari pengguna dan digunakan untuk memulai atau mengkonfirmasi suatu tindakan. Kita dapat menambahkan Button dengan cara klik kanan pada `Hierarchy` > `UI` > `Button`.

Berikut ini penjelasan fungsi masing-masing:
Fungsi | Penjelasan
--- | ---
**Source Image** | Sebuah gambar tombol yang dapat kita ubah bentuknya. Kita juga dapat merubah teks serta warna.
**Interactable** | Ini menentukan apakah komponen akan menerima masukkan. Ketika diset nonaktif (tidak dicentang), maka ia tidak akan menerima masukkan, begitu pun sebaliknya.
**Transition** | Di dalam transisi terdapat 4 komponen, None, Color Tint, Sprite Swap dan Animation.
**None** | Tombol tidak memiliki efek sama sekali.
**Color Tint** | Mengubah warna tombol tergantung pada keadaan saat tombol ditekan. Tujuannya untuk memilih warna dan durasi pudarnya warna (faded). Semakin tinggi angkanya, semakin lambat warna yang memudar.
**Sprite Swap** | Menampilkan sprite (gambar UI) tergantung pada status tombol. Sprite juga dapat dikustomisasi.
**Animation** | Membuat animasi tergantung pada keadaan saat tombol ditekan. Komponen animator harus ada pada transisi animasi. Untuk membuat pengontrol animasi, klik untuk membuat animasi . Lalu pastikan bahwa pengontrol animasi telah ditambahkan ke komponen animator tombol.
**Transition** | Di dalam sub komponen transisi juga terdapat 4 pilihan transisi lainnya, tergantung pada kondisi apa yang dipilih. Keadaan yang berbeda adalah, Normal (normal), Highlighted (disorot), Pressed (ditekan) dan Disabled (dinonaktifkan).
**Normal Color** | Kondisi tombol dalam keadaan normal (default).
**Highlighted Color** | Kondisi saat kursor diarahkan pada tombol.
**Pressed Color** | Kondisi saat tombol ditekan.
**Navigation** | None | Tidak ada navigasi.
**Horizontal** | Menavigasi secara horizontal.
**Vertical** | Menavigasi secara vertikal.
**Automatic** | Navigasi otomatis.
**Explicit** | Dalam mode ini Anda dapat secara eksplisit menentukan letak kontrol pada saat menavigasi ke tombol panah yang berbeda.
**On Click ()** | Anda dapat memasukkan script yang berisi saat tombol ditekan atau menerima aksi (inputan).

Button akan berefek saat ditekan. Berikut ini adalah contoh implementasi script untuk
botton tersebut.
```csharp
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour {
    void CobaKlik() {
        // Output ini akan tampil ketika Tombol diklik
        Debug.Log("Aku diklik!");
    }

    void KlikDenganParameter (string message) {
        // Output ini akan tampil ketika Tombol diklik
        Debug.Log(message);
    }
}
```

## Event System
Event System adalah sistem yang menerima event dari Event Trigger dan memanggil fungsi yang telah diinisialisasi untuk Event System. Event System akan otomatis ditambahkan saat kita memasukkan UI baru. Event Trigger dapat digunakan untuk menentukan fungsi yang Anda panggil untuk setiap peristiwa Event System. Sebagai contoh, berikut ini ada beberapa objek yaitu gambar, teks dan teks akan dimasukkan ke Event System. Kita dapat menambahkan Event System, dengan cara klik kanan pada `Hierarchy` > `UI` > `Event System`.

Kita dapat memasukkan objek tombol ke dalam `Event System`> `First Selected.` Lalu kita dapat menekan tombol saat di Play Mode. Kita juga dapat menambahkan Event Trigger pada objek gambar. Kemudian kita `Add New Event Type` > `Pointer Enter` yang nantinya akan dimasukkan script untuk memindahkan scene dari menu 2 ke menu 1 . Caranya, arahkan pointer ke gambar.

## Text
Text adalah sebuah potongan teks yang tampil pada layar pengguna. Teks memberikan keterangan atau label untuk GUI (Graphic User Interface) atau menampilkan instruksi. Kita juga dapat mengatur jenis, ukuran, posisi, dan warna teks. Kita dapat menambahkan teks dengan cara klik kanan pada `Hierarchy` > `UI` > `Text`.

Berikut ini penjelasan fungsi masing-masing:
Fungsi | Penjelasan
--- | ---
**Text** | Tempat di mana kita menginputkan tulisan.
**Font** | Jenis teks yang tampil.
**Font Style** | Gaya yang diterapkan pada teks. Pilihannya antara Normal, Bold (tebal), Italic (miring) serta Bold-Italic (tebal dan miring).
**Font Size** | Ukuran teks yang ditampilkan.
**Line Spacing **| Pemisahan vertikal antara baris-baris teks.
**Rich Text** | Elemen pengayaan teks.
**Alignment** | Perataan teks secara horizontal dan vertikal.
**Align By Geometry** | Penggunaan luasan geometri untuk mensejajarkan secara horizontal.
**Horizontal Overflow** | Metode untuk menangani situasi di mana teks terlalu lebar untuk masuk ke dalam persegi panjang. Opsinya adalah Wrap and Overflow.
**Vertical Overflow** | Metode untuk menangani situasi di mana teks yang terlalu tinggi untuk masuk ke dalam persegi panjang. Pilihannya adalah Truncate and Overflow.
**Best Fit** | Unity mengabaikan properti ukuran dan cukup menyesuaikan teks ke persegi panjang.
**Color** | Warna yang digunakan untuk me-render teks.
**Material** | Bahan yang digunakan untuk me-render teks.
**Raycast Target** | Target untuk raycasting.

Berikut ini adalah contoh implementasi script untuk teks. Ini adalah nilai string dari komponen Text. Gunanya untuk membaca atau mengedit pesan yang ditampilkan pada Teks. Contoh kodenya seperti di bawah ini.
```csharp
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Texts : MonoBehaviour {
    public static int score;

    Text text;

    void Awake() {
        // Mengatur reference teks
        text = GetComponent <Text> ();

        // Mengembalikkan nilai awal skor
        score = 0;
    }

    void Update() {
        // Jumlah skor yang ditampilkan
        text.text = "Score: " + score;
    }
}
```

## Input Field
Input Field adalah cara untuk membuat Kontrol Teks yang dapat diubah. Di dalamnya kita dapat menginput huruf, nomor, dan simbol. Kita dapat menambahkan Input Field dengan cara klik kanan pada `Hierarchy` > `UI` > `Input Field`.

Berikut ini penjelasan fungsi masing-masing:
Fungsi | Penjelasan
--- | ---
**Interactable** | Ini menentukan apakah komponen akan menerima masukan. Ketika disetel nonaktif (tidak dicentang), maka tidak akan menerima masukkan, sebaliknya pun begitu.
**Transition** | Digunakan untuk mengatur bagaimana transisi field input saat Normal, Highlighted, ditekan atau dinonaktifkan.
**Navigation** | Properti yang menentukan urutan kontrol.
**Text Component** | Referensi ke elemen teks yang digunakan sebagai isi dari Field Input.
**Text** | Kolom teks gunanya nanti akan diisikan sebuah teks atau nilai. Character Limit | Nilai jumlah karakter maksimum yang dapat dimasukkan ke dalam kolom input.
**Content Type** | Penentuan jenis karakter yang diterima oleh field input.
**Line Type** | Menentukan bagaimana teks diformat di dalam bidang teks.
**Placeholder** | Ini adalah grafik 'kosong' yang bersifat opsional untuk menunjukkan Bidang Masukan kosong teks.
**Caret Blink Rate** | Menentukan tingkat kedipan untuk tanda yang ditempatkan pada garis. Gunanya untuk menunjukkan penyisipan teks.
**Selection Color** | Warna pilihan latar belakang bagian teks.
**Hide Mobile Input** | Sembunyikan bidang masukan asli yang melekat pada keyboard di layar pada perangkat seluler. Ini hanya berfungsi di perangkat iOS.
**On Value Change ()** | UnityEvent yang dipanggil ketika konten teks dari Input Field berubah. Dapat mengirim konten teks sebagai argumen dinamis dengan tipe string.
**On End Edit ()** | UnityEvent yang dipanggil ketika pengguna selesai mengedit konten teks baik dengan mengirimkan maupun mengklik suatu tempat yang menghilangkan fokus dari Input Field.

Adapun contoh implementasi script untuk Input Field adalah sebagai berikut:
```csharp
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InputFields : MonoBehaviour {
    public InputField mainInputField;

    public void Start() {
        mainInputField.text = "Tuliskan teks disini...";
    }
}
```

## Toogle
Toggle adalah kotak centang yang memungkinkan pengguna mengaktif / non-aktifkan opsi. Kita dapat menambahkan Toggle dengan cara klik kanan pada `Hierarchy` > `UI` > `Toggle`.

Berikut ini penjelasan fungsi masing-masing:
Fungsi | Penjelasan
--- | ---
**Interactable** | menentukan apakah komponen akan menerima masukan. Ketika disetel non-aktif (tidak dicentang), maka tidak akan menerima masukkan, begitu sebaliknya.
**Transition** | menentukan cara kontrol merespon tindakan pengguna secara visual.
**Navigation** | menentukan urutan kontrol.
**Is On** | mengaktif / non-aktifkan toggle.
**Toggle Transition** | Cara toggle bereaksi secara grafis ketika nilainya diubah. Pilihannya adalah None (yaitu, tanda centang hanya muncul atau menghilang) dan Fade (yaitu, tanda centang memudar masuk atau keluar).
**Graphic** | Gambar yang digunakan untuk tanda centang.
**Group** | Toggle Group (jika ada) tempat Toggle ini berada.

Berikut ini adalah contoh implementasi script untuk Toggle. Script ini mengembalikan atau mengatur apakah Toggle aktif / tidak.
```csharp
using UnityEngine;
using UnityEngine.UI;

public class Toogles : MonoBehaviour {
    Toggle m_Toggle;
    public Text m_Text;

    void Start() {
        // Ambil Toggle GameObject
        m_Toggle = GetComponent<Toggle>();

        // Inisialisasi Teks untuk mengecek apakah Toggle dalam keadaan positif (on) atau negatif (off)
        m_Text.text = "Toggle dalam keadaan: " + m_Toggle.isOn;
    }
}
```

## Dropdown
Dropdown adalah komponen yang memungkinkan pengguna memilih satu opsi dari daftar. Setelah diklik, maka daftar opsi akan terbuka sehingga opsi baru dapat dipilih. Setelah memilih opsi baru, daftar ditutup lagi, dan kontrol menunjukkan opsi yang barudipilih. Kita dapat menambahkan Dropdown dengan cara klik kanan pada `Hierarchy` > `UI` > `Dropdown`.

Berikut ini adalah penjelasan fungsi masing-masing:
Fungsi | Penjelasan
--- | ---
**Interactable** | menentukan apakah komponen akan menerima masukan. Ketika disetel nonaktif (tidak dicentang), maka tidak akan menerima masukkan, begitu sebaliknya.
**Transition** | menentukan cara kontrol merespon tindakan pengguna secara visual.
**Navigation** | menentukan urutan kontrol.
**Template** | The Rect Transform dari template untuk daftar dropdown.
**Caption Text** | Komponen Text untuk menahan teks dari opsi yang sedang dipilih.
**Caption Image** | Komponen gambar untuk menyimpan gambar pilihan.
**Item Text** | Komponen Text untuk memegang teks item.
**Item Image** | Komponen Gambar untuk menyimpan gambar item.
**Value** | Indeks opsi yang saat ini dipilih. Nol (0) adalah opsi pertama, satu (1) yang kedua, dan seterusnya.
**Options** | Daftar teks dan gambar dapat ditentukan untuk setiap opsi.

Berikut ini adalah contoh implementasi script untuk Dropdown, yakni tambahan beberapa opsi teks ke opsi Dropdown berdasarkan daftar string, berikut contoh code nya:
```csharp
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dropdowns : MonoBehaviour {
    // Buat Daftar opsi Dropdown baru
    List<string> m_DropOptions = new List<string> {"Opsi 1", "Opsi 2", "Opsi 3"};

    // Ini adalah Dropdown
    Dropdown m_Dropdown;

    void Start() {
        // Ambil GameObject Dropdown yang dilampirkan pada script
        m_Dropdown = GetComponent<Dropdown>();

        // Tambahkan opsi yang dibuat pada Daftar
        m_Dropdown.AddOptions(m_DropOptions);
    }
}
```

## Slider
Slider adalah sebuah nilai numerik dari rentang yang telah ditentukan. Pengguna dapat men-drag mouse untuk memilih nilai numerik tersebut. Kita dapat menambahkan Slider, dengan cara klik kanan pada `Hierarchy` > `UI` > `Slider`.

Berikut ini penjelasan fungsi masing-masing:
Fungsi | Penjelasan
--- | ---
**Interactable** | menentukan apakah komponen akan menerima masukan. Ketika disetel nonaktif (tidak dicentang), maka tidak akan menerima masukkan, begitu sebaliknya.
**Transition** | Di dalam komponen transisi terdapat 4 pilihan transisi tergantung pada pilihan kondisi Keadaan yang berbeda adalah, Normal (normal), Highlighted (disorot), Pressed (ditekan) dan Disabled (dinon-aktifkan). Di dalam transisi terdapat 4 komponen lainnya, yaitu.
**None** | Tombol tidak memiliki efek keadaan sama sekali.
**Color Tint** | Mengubah warna tombol tergantung pada keadaan saat tombol ditekan. Tujuannya untuk memillih warna sesuai selera serta mengatur durasi pudarnya warna (faded). Semakin tinggi angkanya, semakin lambat warna yang memudar.
**Sprite Swap** | Memungkinkan sprite (gambar UI) untuk tampil tergantung pada status tombol, sprite juga dapat dikustomisasi.
**Animation** | Memungkinkan animasi terjadi tergantung pada keadaan tombol. Komponen animator harus ada untuk digunakan pada transisi animasi. Untuk membuat pengontrol animasi, klik untuk membuat animasi (atau buat sendiri) dan pastikan bahwa pengontrol animasi telah ditambahkan ke komponen animator tombol.
**Navigation** | 
**None** | Tidak ada navigasi.
**Horizontal** | Menavigasi secara Horizontal.
**Vertical** | Menavigasi secara Vertikal.
**Automatic** | Navigasi otomatis.
**Explicit** | Dalam mode ini kamu dapat secara eksplisit (jelas) menentukan dimana kontrol menavigasi ke tombol panah yang berbeda.
**Fill Rect** | Grafik yang digunakan untuk mengisi area kontrol.
**Handle Rect** | Grafik yang digunakan untuk bagian "handle" untuk menggeser.
**Direction** | Yang mana nilai arah dari slider akan meningkat ketika handle diseret Pilihannya adalah Kiri ke Kanan, Kanan ke Kiri, Bawah ke Atas dan Atas ke Bawah.
**Min Value** | Nilai penggeser saat handle berada di ujung bawah atau paling kiri (ditentukan oleh arah).
**Max Value** | Nilai penggeser saat handle berada di ujung atas atau paling kanan (ditentukan oleh arah).
**Whole Numbers** | Slider harus dibatasi ke nilai integer.
**Value** | Nilai numerik dari slider. Jika nilai ditetapkan di Inspector akan digunakan sebagai nilai awal, tetapi akan berubah pada saat dijalankan (play mode).

Adapun contoh implementasi script untuk Slider yang memiliki nilai, berikut contoh code nya:
```csharp
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Sliders : MonoBehaviour {
    public Slider mainSlider;

    // Dipanggil ketika tombol submit diklik
    public void CobaSlider() {
        // Menampilkan nilai pada console
        Debug.Log(mainSlider.value);
    }
}
```

## Scrollbar
Scrollbar adalah sebuah antarmuka yang memungkinkan pengguna untuk menggulir (scroll) gambar atau tampilan lain yang terlalu besar untuk dilihat. Contoh yang biasa digunakan pada Scrollbar adalah bar vertikal dan horizontal untuk melihat bagian dari gambar. Kita dapat menambahkan Scrollbar, dengan cara klik kanan pada `Hierarchy` > `UI` > `Scrollbar`.

Berikut ini penjelasan fungsi masing-masing:
Fungsi | Penjelasan
--- | ---
**Interactable** | Ini menentukan apakah komponen akan menerima masukan. Ketika disetel nonaktif (tidak dicentang), maka tidak akan menerima masukkan, sebaliknya pun begitu.
**Transition** | Didalam komponen transisi terdapat 4 pilihan transisi tergantung pada kondisi apa yang dipilih. Keadaan yang berbeda adalah | Normal (normal), Highlighted (disorot), Pressed (ditekan) dan Disabled (dinonaktifkan). Dan didalam transisi terdapat 4 komponen lainnya, yaitu.
**None** | Tombol tidak memiliki efek keadaan sama sekali.
**Color Tint** | Mengubah warna tombol tergantung pada keadaan saat tombol ditekan. Hal ini dimungkinkan untuk memilih warna untuk disesuaikan. Juga dimungkinkan untuk mengatur durasi pudarnya warna (faded). Semakin tinggi angkanya, semakin lambat warna yang memudar.
**Sprite Swap** | Memungkinkan sprite (gambar UI) untuk ditampilkan tergantung pada status tombol, sprite juga dapat dikustomisasi.
**Animation** | Memungkinkan animasi terjadi tergantung pada keadaan tombol, komponen animator harus ada untuk digunakan pada transisi animasi. Untuk membuat pengontrol animasi, klik untuk membuat animasi (atau buat sendiri) dan pastikan bahwa pengontrol animasi telah ditambahkan ke komponen animator tombol.
**Navigation** |
**None** | Tidak ada navigasi.
**Horizontal** | Menavigasi secara Horizontal.
**Vertical** | Menavigasi secara Vertikal.
**Automatic** | Navigasi otomatis.
**Explicit** | Dalam mode ini kamu dapat secara eksplisit (jelas menentukan dimana kontrol menavigasi ke tombol panah yang berbeda.
**Fill Rect** | Grafik yang digunakan untuk mengisi area kontrol.
**Handle Rect** | Grafik yang digunakan untuk bagian "handle" untuk menggeser.
**Direction** | Yang mana nilai arah dari slider akan meningkat ketika handle diseret. Pilihannya adalah Kiri ke Kanan, Kanan ke Kiri, Bawah ke Atas dan Atas ke Bawah.
**Value** | Nilai numerik dari slider. Jika nilai ditetapkan di Inspector akan digunakan sebagai nilai awal, tetapi akan berubah pada saat dijalankan (play mode).
**Size** | Ukuran pecahan handle dalam Scrollbar, dalam rentang 0,0 hingga 1,0.
**Number Of Steps** | Jumlah posisi scroll yang berbeda pada Scrollbar.

Adapun contoh implementasi script untuk Scrollbar, posisi handle vertikal sebagai nilai antara 0 dan 1, dengan 0 berada di bagian bawah dan 1 berada di bagian atas, berikut contoh code nya:
```csharp
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Scrollbars : MonoBehaviour {
    public ScrollRect newScrollRect;
    public Scrollbar newScrollBar;

    public void Start() {
        // Ubah posisi Handle vertikal
        newScrollRect.verticalNormalizedPosition = 0.5f;
    }
}
```

## Scroll View
Scroll View adalah sebuah konten yang membutuhkan banyak ruang untuk ditampilkan di area yang kecil. Scroll View juga menyediakan fungsi untuk mengemas konten yang ada. Scroll View juga dapat dikombinasikan dengan satu atau dua Scrollbar yang dapat diseret untuk menggeser secara Horizontal atau Vertikal. Kita dapat menambahkan Scroll View, dengan cara klik kanan pada `Hierarchy` > `UI` > `Scroll View`.

Berikut ini penjelasan fungsi masing-masing:
Fungsi | Penjelasan
--- | ---
**Content** | Ini adalah reference ke RectTransform dari elemen UI yang akan digulir, misalnya gambar dengan skala yang besar.
**Horizontal** | Menggeser secara horizontal.
**Vertical** | Menggeser secara vertikal.
**Movement Type** | Tidak terbatas, elastis atau dijepit. Gunakan Elastic atau Clamped untuk memaksa konten tetap berada di dalam batas-batas area ScrollRect.
**Elasticity** | Ini adalah jumlah pantulan yang digunakan dalam mode elastisitas.
**Scroll Sentivity** | Sensitivitas untuk scroll dan trackpad.
**Viewport** | Reference ke viewport RectTransform yang merupakan parent dari konten RectTransform.
**Horizontal Scrollbar** | Reference opsional untuk elemen scrollbar horizontal.
**Visibility** | Scrollbar secara otomatis akan disembunyikan saat tidak diperlukan, dan secara opsional akan memperluas viewport juga.
**Spacing** | Ruang antara scroll dan viewport.
**Vertical Scrollbar** | Reference opsional untuk elemen scrollbar vertikal.

---

## Kredit
[Dicoding Indonesia](https://www.dicoding.com/)