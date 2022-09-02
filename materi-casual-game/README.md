# Materi Casual Game

Daftar isi:
- [Materi Casual Game](#materi-casual-game)
  - [Sprite](#sprite)
  - [Camera](#camera)
  - [Parent dan Child](#parent-dan-child)
  - [Input](#input)
  - [Scene](#scene)
  - [Audio](#audio)
  - [Kredit](#kredit)

## Sprite
Sprite adalah obyek grafis 2D yang digunakan untuk game 2D. Jika Anda terbiasa bekerja dalam 3D, sprite pada dasarnya hanya menggunakan tekstur standar. Namun, demi efisiensi dan kenyamanan selama pengembangan, terdapat teknik khusus untuk menggabungkan dan mengelola tekstur sprite tersebut. 

Banyak file type yang mendukung sprite seperti PSD, TIFF, JPG, TGA, PNG, GIF, BMP, IFF, dan PICT. Untuk meng-import gambar dengan multi-layer maka baiknya Anda gunakan PSD atau TIFF. Untuk memasukkan gambar tidak transparan gunakan JPEG, Tetapi, kalau gambarnya transparan lebih baik gunakan PNG. 

Untuk ukuran asset Sprite -misalnya dengan resolusi 1280x720- dianjurkan untuk mendesain asset menggunakan resolusi tersebut. Dengan contoh gambar background 1280x720, maka kita gunakan ukuran obyek yang lebih kecil, misalnya 512x512. Dengan menyesuaikan ukuran , diharapkan asset yang tampil tidak pecah karena diperbesar atau diperkecil. Lebih lanjut, dengan ukuran asset yang tepat dan tidak terlalu besar, ukuran berkas jadi lebih optimal.

Tools yang digunakan untuk mengolah gambar antara lain:
- Adobe Photoshop (berbayar)
- GIMP (gratis)
  
Dengan tools tersebut Anda dapat mengedit gambar sesuai kebutuhan, seperti membuat, memotong, mengatur resolusi, mengatur warna gambar, dan banyak lagi. Sementara untuk mencari gambar, Anda dapat menggunakan bantuan Google Images. Tapi ingat, perhatikanlah lisensi dari masing-masing gambar yang digunakan. Beberapa situs yang menyediakan asset game secara gratis antara lain:
- https://itch.io/game-assets/free
- https://opengameart.org/
- https://kenney.nl/assets


## Camera
Setiap membuat proyek baru di Hierarchy, secara default ada Main Camera. Area Camera ditandai dengan garis yang berwarna putih. Anda dapat mengetahui Area tersebut dengan memilih (select) Main Camera pada jendela Hierarchy. Area camera tersebut merupakan tampilan (view) yang akan ditampilkan di jendela game. Objek yang berada di luar jangakauan kamera tidak dapat ditampilkan di jendela game. Oleh karena itu, kita perlu menyesuaikan resolusi yang terdapat di jendela Game. Di Unity secara default menggunakan Free Aspect yang rasionya mengikuti rasio di Jendela Game.

Berikut ini adalah resolusi dari beberapa peranti (device) :
- QVGA (320×240)
- HVGA (480×320)
- WVGA (800×480)
- FWVGA (854×480)
- DVGA (960×640)
- WSVGA (1024×600)
- XGA (1024×768)
- WXGA (1366×768 / 1360×768 / 1280×800)
- QXGA (2048×1536)
- qHD (960×540)
- HD (1280×720)
- FHD (1920×1080)
- QHD (2560×1440)

Anda dapat memilih / menambahkan rasio atau nilai nilai fixed resolusi. Cukup klik tanda plus kemudian masukkan nilai sesuai dengan resolusi peranti yang Anda kembangkan.Perbedaannya adalah sebagai berikut:

- **Free Aspect**, Dengan menggunakan Free Aspect, maka tampilan akan lebih fleksibel dengan menyesuaikan view pada resolusi jendela Game. Tampilan dapat terlihat lebih besar atau lebih kecil.
- Menggunakan resolusi **1024x768** atau sama juga dengan menggunakan perbandingan **4:3** dari kelipatan 256.
- Menggunakan rasio **16:9**, maka akan terlihat terpotong di setiap sisinya karena menyesuaikan ukuran tersebut.

Jadi, penggunaan resolusi yang lebih lebar akan lebih aman. Anda juga dapat membayangkan tampilannya jika game Anda dibuka di beberapa peranti.

## Parent dan Child
Di jendela Hierarchy ada 2 (dua) kondisi yang terjadi pada GameObject, yaitu sebagai Parent atau Child.

Untuk mengelola Child pada GameObject ada beberapa cara:
- Klik kanan pada GameObject di Hierarchy kemudian pilih object lain misal Cube. Secara otomatis Cube baru tersebut merupakan Child dari GameObject tersebut.
- Menambahkan Child dengan men-drag GameObject yang ingin dijadikan Child ke dalam GameObject yang akan dijadikan sebagai Parent.
- Untuk melepas Child dari Parent, Anda dapat men-drag Child tersebut ke luar GameObject yang sebelumnya menjadi Parent. 

Untuk mengatur Transform pada Sprite di Game, Anda juga dapat menggunakan Toolbox yang telah disediakan Unity. Toolbox ini berada di kiri atas pada editor unity dan digunakan untuk mengatur nilai Transform dengan visual.

Berikut ini adalah adalah tiga fungsi utama pada Toolbox tersebut:
- **Hand**: untuk mengatur tampilan view pada jendela Scene tanpa harus mengubah posisi gameobject. Klik tengah pada Mouse untuk shortcut ke mode Hand.
- **Tool 3D:** untuk mengatur nilai x, y, dan z, baik itu posisi, rotasi, maupun skala.
- **Tool 2D**: untuk mengatur nilai x dan y, baik itu posisi, rotasi, maupun skala.

Jika terdapat perubahan posisi, rotasi dan skala pada parent, child juga akan mengikuti. Namun sebaliknya, perubahan pada Child maka tidak akan mempengaruhi parent. Kondisi Child ditandai dengan perbedaan posisi yang lebih ke dalam. Hal ini memudahkan kita untuk mengelompokkan object mana saja yang perlu di-trigger dalam satu intruksi (rotasi, posisi, skala). Setiap perubahan pada Parent dapat mempengaruhi perubahan pada Child. Jika GameObject Parent tidak aktif, maka GameObject sebagai Child juga tidak aktif.

## Input
Anda dapat memperoleh data input dari Keyboard, Mouse, Joystick, Touch, Gyro, Compass, Accelerometer, dan lain lain. Sedangkan untuk memperoleh nilai dari input peranti tersebut, Anda dapat menggunakan Input Manager. Materi tentang Input Manager ini akan kita praktikkan juga pada modul selanjutnya OK, untuk menampilkan Input Manager ini, Anda dapat mencari pada Menu Edit > Project Settings > Input.

Beberapa contoh input yang dapat Anda gunakan seperti Fire1, Jump, Horizontal, Vertical, dan lain-lain. Salah satu contoh penggunaan Axis Fire1 misalnya dengan tekan tombol Ctrl kiri atau klik kiri pada mouse. Sedangkan untuk memanggil di script, Anda dapat menulis sebagai berikut:
```csharp
Input.GetAxis("Fire1")
```
Tanpa menggunakan Axis, Anda juga dapat langsung memanggil di script sebagai berikut untuk merespon input klik kiri pada mouse.
```csharp
Input.GetButtonDown(0)
```
Selengkapnya Anda dapat mengunjungi tautan di bawah ini:
https://docs.unity3d.com/ScriptReference/Input.html.

## Scene
Scene merupakan wadah yang menampung GameObject atau semua hal yang kita butuhkan. Satu Scene dapat dipandang sebagai satu level atau satu screen/tampilan dari sebuah object. Scene menyimpan semua GameObject yang terdapat di Hierarchy. Scene memiliki Extensi dot Unity yang pernah dipraktikkan di modul terdahulu. Sekarang kita akan membahas cara menggunakan Scene sebagai tampilan halaman pada sebuah game. Berikut ini adalah gambaran Scene yang nanti akan dibuat. Ketika aplikasi pertama kali dibuka, halaman Home akan tampil. Tekan tombol Enter, maka halaman Gameplay muncul. Untuk keluar dari halaman Gameplay dan masuk Home, tekan tombol Escape. Untuk keluar dari aplikasi, tekan tombol Escape. Kemudian muncul pertanyaan apakah ingin keluar. Tekan tombol Escape sekali lagi, maka Anda akan keluar game. Namun jika tekan Enter maka kembali ke Home.

## Audio
Game akan terasa hambar jika tidak ada audio, elemen krusial dalam sebuah game. Audio sangat membantu memberi suasana tertentu atau memperjelas material sebuah benda. Dari audio kita mengenal tentang musik dan sound. Musik merupakan dari sebuah sound, namun sebuah sound belum tentu sebuah musik.

Beberapa jenis audio yang di-support Unity antara lain:
- AIFF
- WAV
- MP3
- Ogg

Di dalam Unity, langkah langkah sampai dengan sebuah Audio berbunyi adalah sebagai berikut:

Audio disimpan dalam variable AudioClip, kemudian dari Audio Source memancarkan audio yang terdapat di variabel Audio clip. Audio Listener berperan sebagai penerima dari yang dipancarkan oleh Audio Source. Audio Listener yang diterima itulah yang sampai di telinga kita. Untuk lebih jelasnya,
kunjungi https://docs.unity3d.com/Manual/AudioOverview.html

Tools Audio
- Audacity.sourceforge.net
- tazman-audio.co.uk
- audiokinetic.com

Free Audio
- http://www.get-sounds.com/
- http://www.freesound.org
- http://soundimage.org/
- https://www.partnersinrhyme.com/pir/PIRsfx.shtml
- http://www.pygame.org/wiki/resources

Sound Generate
-  http://www.drpetter.se/project_sfxr.html

## Kredit
[Dicoding Indonesia](https://www.dicoding.com/)