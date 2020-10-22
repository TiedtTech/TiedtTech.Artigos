public ActionResult Cadastro(int? id)
{
    if (id != null)
    {
        using (var db = new Conexao())
        {
            var registro = db.Pessoa.Find(id);
            return View(registro);
        }
    } 
    return View();
}  