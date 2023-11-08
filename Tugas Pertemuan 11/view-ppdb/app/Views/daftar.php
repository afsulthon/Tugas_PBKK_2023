<!DOCTYPE html>
<html lang="en">

<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>PPDB Online SMA Informatika 2023</title>
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
  <link rel="shortcut icon" href="https://upload.wikimedia.org/wikipedia/commons/9/9c/Logo_of_Ministry_of_Education_and_Culture_of_Republic_of_Indonesia.svg" type="image/x-icon">
  <script src="https://kit.fontawesome.com/82d0e7f3eb.js" crossorigin="anonymous"></script>
  <style>
    @import url('https://fonts.googleapis.com/css2?family=Inter:wght@100;200;300;400;500;600;700;800;900&display=swap');

    body {
      font-family: 'Inter', sans-serif;
    }

    .navbar-brand,
    .card-title {
      font-weight: 700;
    }

    .form-label {
      font-weight: 600;
    }
  </style>
</head>

<body>
  <header>
    <nav class="navbar navbar-expand-lg shadow-sm">
      <div class="container py-2">
        <img src="https://upload.wikimedia.org/wikipedia/commons/9/9c/Logo_of_Ministry_of_Education_and_Culture_of_Republic_of_Indonesia.svg" alt="Logo" width="40" class="d-inline-block">
        <span class="navbar-brand ms-2 mb-0 h1">PPDB Online SMA Informatika 2023</span>
        <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
          <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarNav">
          <ul class="navbar-nav">
            <li class="nav-item">
              <a class="nav-link" href="#">Home</a>
            </li>
            <li class="nav-item">
              <a class="nav-link" href="#">Pengumuman</a>
            </li>
            <li class="nav-item">
              <a class="nav-link active" aria-current="page" href="#">Daftar</a>
            </li>
            <li class="nav-item">
              <a class="nav-link" href="#">Kontak</a>
            </li>
          </ul>
          <ul class="navbar-nav ms-auto">
            <li class="nav-item">
              <a href="#" class="btn btn-primary">
                <i class="fas fa-user me-2"></i>Login
              </a>
            </li>
          </ul>
        </div>
      </div>
    </nav>
  </header>

  <main>
    <div class="container pt-4">
      <h1 class="display-6">Pendaftaran Tahun Ajaran 2023/2024</h1>
      <div class="row pt-4">
        <div class="col-auto me-5">
          <img src="https://ptp.ft.unm.ac.id/wp-content/uploads/sites/23/2018/01/register.png" alt="">
        </div>
        <div class="col">
          <div class="card shadow-sm">
            <div class="card-header">
              <h5 class="card-title pt-2">Pendaftaran</h5>
            </div>
            <div class="card-body">
              <form>
                <div class="mb-3">
                  <label for="nisn" class="form-label">NISN</label>
                  <input type="text" class="form-control" id="nisn" placeholder="NISN" aria-describedby="NISN">
                </div>
                <div class="row">
                  <div class="col">
                    <div class="mb-3">
                      <label for="nama-lengkap" class="form-label">Nama Lengkap</label>
                      <input type="text" class="form-control" id="nama-lengkap" placeholder="Nama Lengkap" aria-describedby="Nama Lengkap">
                    </div>
                  </div>
                  <div class="col">
                    <div class="mb-3">
                      <label for="nama-panggilan" class="form-label">Nama Panggilan</label>
                      <input type="text" class="form-control" id="nama-panggilan" placeholder="Nama Panggilan" aria-describedby="Nama Panggilan">
                    </div>
                  </div>
                </div>
                <div class="mb-3">
                  <label for="tempat-lahir" class="form-label">Tempat Lahir</label>
                  <input type="text" class="form-control" id="tempat-lahir" placeholder="Tempat Lahir" aria-describedby="Tempat Lahir">
                </div>
                <div class="mb-3">
                  <label for="tanggal-lahir" class="form-label">Tanggal Lahir</label>
                  <input type="date" class="form-control" id="tanggal-lahir" placeholder="Tanggal Lahir" aria-describedby="Tanggal Lahir">
                </div>
                <button type="submit" class="btn btn-primary">
                  <i class="fas fa-save me-2"></i>Submit
                </button>
              </form>
            </div>
          </div>
        </div>
      </div>
    </div>
  </main>
</body>

</html>