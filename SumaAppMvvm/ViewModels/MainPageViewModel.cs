using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
    

namespace SumaAppMvvm.ViewModels
{
    public partial class MainPageViewModel: ObservableObject
    {
        [ObservableProperty]
        private string numero1;

        [ObservableProperty]
        private string numero2;

        [ObservableProperty]
        private string resultado;

  


      
           
        [RelayCommand]
        private void Sumar()
        {
            if (string.IsNullOrWhiteSpace(Numero1) || string.IsNullOrWhiteSpace(Numero2))
            {
                Resultado = "Por favor, llena todos los campos.";
                return;
            }

            if (double.TryParse(Numero1, out double num1) && double.TryParse(Numero2, out double num2))
            {
                Resultado = $" {num1 + num2}";
            }
            else
            {
                Resultado = "Por favor, ingresa valores numéricos válidos.";
            }
        }
        [RelayCommand]
        private void Limpiar()
        {
            Numero1 = string.Empty;
            Numero2 = string.Empty;
            Resultado = string.Empty;
        }


    }
}
