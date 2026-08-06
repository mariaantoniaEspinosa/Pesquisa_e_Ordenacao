public class Principal { // Removido o "static"
    public static void main(String[] args) {
        MedicaoModel model = new MedicaoModel();
        MedicaoView view = new MedicaoView();
        
        MedicaoController controller = new MedicaoController(model, view);
        controller.iniciar();
    }
}
