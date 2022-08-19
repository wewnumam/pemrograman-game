# Roll a Ball

Versi Unity: 2021.3.6f1 LTS 

Daftar isi:
- [Roll a Ball](#roll-a-ball)
  - [Setup Game](#setup-game)
    - [Membuat Project Unity](#membuat-project-unity)
    - [Membuat *Scene* Baru](#membuat-scene-baru)
    - [Membuat GameObject *Plane*](#membuat-gameobject-plane)
    - [Membuat GameObject Player](#membuat-gameobject-player)
    - [Menyesuaikan Pencahayaan](#menyesuaikan-pencahayaan)
    - [Menambahkan Warna Menggunakan *Materials*](#menambahkan-warna-menggunakan-materials)
  - [Menggerakkan Player](#menggerakkan-player)
  - [Setup Area](#setup-area)
  - [Membuat Objek Koleksi](#membuat-objek-koleksi)
  - [Mendeteksi Tumbukan](#mendeteksi-tumbukan)
  - [Menampilkan Skor dan Teks](#menampilkan-skor-dan-teks)
  - [*Build* Game](#build-game)

## Setup Game

### Membuat Project Unity
1. Buka Unity Hub
2. `New Project`
3. Pilih `3D (URP)` atau *Universal Render Pipeline*.
    > Universal Render Pipeline, atau URP, memungkinkan Anda membuat grafik yang dioptimalkan dengan cepat dan mudah di berbagai platform mulai dari seluler hingga konsol dan PC kelas atas.
4. Beri nama projek anda dan pilih lokasi folder.
5. `Create Project`

### Membuat *Scene* Baru
Sebelumnya, buat folder template baru di dalam direktori *Assets* dan pindahkan semua folder aset bawaan yang ada ke sana agar proyek tetap teratur. 
   > Sangat penting untuk menjaga proyek Anda tetap rapi. Ini akan membantu Anda dan orang lain menemukan aset di kemudian hari.
1. Untuk membuat *Scene* baru di editor, di menu atas, buka `File` > `New Scene`.
2. Selanjutnya, simpan adegan dengan kembali ke `File` > `Save As`. Sekarang simpan adegan Anda ke dalam folder baru bernama *Scenes*.

### Membuat GameObject *Plane*
- Untuk membuat *Plane*, di menu atas, buka `Game Object` > `3D Object` > `Plane`
- Untuk mengubah nama objek, Anda dapat mengubahnya pada *title box* di `Inspector`.
- Untuk memanipulasi ukuran `Plane`, gunakan `Scale Tool` pada atau shortcut tombol `R`.

### Membuat GameObject Player
1. Untuk membuat bola, di `Hierarchy`, klik icon `+` > `3D Object` > `Sphere`.
2. Ubah nama *Sphere* menjadi *Player*.
3. Setel ulang `Transform` untuk memastikannya pada titik asal *Scene*, 0,0,0.
   > Pilih `Edit` > `Frame Selected` di menu atas, atau saat kursor berada di atas tampilan Scene, tekan tombol `F` pada keyboard Anda. Ini akan memfokuskan kamera Scene view pada GameObject *Sphere* baru Anda.
4. Jika Anda menaikkan objek *Player* setengah unit di sepanjang sumbu y, itu akan sempurna di atas *Plane*. Untuk melakukan ini, di `Inspector`, temukan komponen ``Transform``. Atur posisi nilai y menjadi 0,5.

### Menyesuaikan Pencahayaan
1. Di `Hierarchy`, pilih `Directional Light` dan kemudian tinjau di `Inspector`. Ubah warna cahaya dari kuning menjadi putih murni. Lakukan ini dengan memilih kotak pilihan berwarna untuk membuka roda warna.
   > Anda dapat menggunakan *color picker* untuk memilih warna. Untuk mendapatkan hasil yang spesifik, sebaiknya pilih nilai yang tepat.
2. Untuk warna putih solid, atur nilai RGB ke 255, 255, dan 255.

### Menambahkan Warna Menggunakan *Materials*

## Menggerakkan Player

## Setup Area

## Membuat Objek Koleksi

## Mendeteksi Tumbukan

## Menampilkan Skor dan Teks

## *Build* Game

