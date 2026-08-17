using System.Diagnostics;


public class OrdenacaoController
{
    private OrdenacaoModel _model;
    private OrdenacaoView _view;

    public OrdenacaoController(OrdenacaoModel model, OrdenacaoView view)
    {
        _model = model;
        _view = view;
    }

    public void Executar(int quantidade)
    {
        _model.PopularListas(quantidade);
        Stopwatch sw = new Stopwatch();

        // BOLHA
        sw.Start();
        OrdenacaoModel.Bolha(_model.ListaBolha);
        sw.Stop();
        _view.ExibirTempo(sw.ElapsedMilliseconds, "Ordenacao por bolha");        
        sw.Reset();

        // INSERÇÃO
        sw.Start();
        OrdenacaoModel.Insercao(_model.ListaInsercao);
        sw.Stop();
        _view.ExibirTempo(sw.ElapsedMilliseconds, "Ordenacao por insercao");
        sw.Reset();

        // SELEÇÃO
        sw.Start();
        OrdenacaoModel.Selecao(_model.ListaSelecao);
        sw.Stop();
        _view.ExibirTempo(sw.ElapsedMilliseconds, "Ordenacao por selecao");
        sw.Reset();

        // AGITAÇÃO
        sw.Start();
        OrdenacaoModel.Agitacao(_model.ListaAgitacao);
        sw.Stop();
        _view.ExibirTempo(sw.ElapsedMilliseconds, "Ordenacao por agitacao");        
        sw.Reset();

        // SORT NATIVO
        sw.Start();
        _model.ListaSort.Sort();
        sw.Stop();
        _view.ExibirTempo(sw.ElapsedMilliseconds, "Ordenacao por sort nativo");
        sw.Reset();
    }
}
