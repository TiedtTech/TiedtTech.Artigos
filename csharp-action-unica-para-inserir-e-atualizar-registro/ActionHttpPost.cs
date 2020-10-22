public ActionResult Cadastro(Pessoa model)
{
    using (var db = new Conexao())
    {
        if (model.PessoaID == 0)
        {
            db.Pessoa.Add(model);
        }
        else
        {
            var registro = db.Pessoa.Find(model.PessoaID);
            UpdateModel(registro);
        }
        db.SaveChanges();
        return RedirectToAction("Cadastro", controller, new { id = model.PessoaID });
    }           
}