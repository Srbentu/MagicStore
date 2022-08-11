﻿using MagicStore.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MagicStore.Components;

public class CategoriaMenu : ViewComponent
{
    private readonly ICategoriaRepository _categoriaRepository;

    public CategoriaMenu(ICategoriaRepository categoriaRepository)
    {
        _categoriaRepository = categoriaRepository;
    }


    public IViewComponentResult Invoke()
    {
        var categorias = _categoriaRepository.Categorias.OrderBy(_categoriaRepository => _categoriaRepository.CategoriaNome);
        return View(categorias);
    }
}
