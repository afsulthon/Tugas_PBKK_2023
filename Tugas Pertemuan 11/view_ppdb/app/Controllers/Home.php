<?php

namespace App\Controllers;

class Home extends BaseController
{
    public function daftar(): string
    {
        return view('daftar');
    }
}
