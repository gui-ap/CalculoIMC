using System;

class Pessoa {
    public double peso,altura;

    public double IMC() {
        return peso / (altura * altura);
    }

    public string saberMedia(double imc) {
         string retorno;

        if(imc < 18.5) {
            retorno = "Abaixo do peso";
        } else if (imc < 25) {
            retorno = "Peso normal";
        } else if (imc < 30) {
            retorno = "Acima do peso";
        } else if (imc < 35) {
            retorno = "Obesidade I";
        } else if (imc < 40) {
            retorno = "Obesidade II";
        } else if (imc >= 40) {
            retorno = "Obesidade III";
        } else {
            retorno = "Numero invalido";
        }

        return retorno;
    }

    public void Mensagem () {
        double ExibirIMC = IMC();
        string ExibirMedia = saberMedia(ExibirIMC);

        Console.WriteLine("Seu IMC e de :" + ExibirMedia);
        Console.WriteLine(ExibirMedia);
   
}
}


