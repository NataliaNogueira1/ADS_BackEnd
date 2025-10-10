![senai_logo](https://transparencia.sp.senai.br/Content/img/logo-senai.png)

# Lista de exercícios 03: Classes C#, Sobrecarga de Métodos e Exceções.

Profº.: Cainã Antunes Silva  
Faculdade de Tecnologia **SENAI Sorocaba**  
Tecnólogo em Análise e Desenvolvimento de Sistemas (ADS)
___

> O objetivo desta lista de exercícios é praticar o uso das Classes C# disponíveis no namespace system. Além disso esta atividade ajudará a compreender o funcionamento de classes estáticas, finais, sobrecarga de métodos e exceções.  

O reaproveitamento de código é essencial no desenvolvimeto de aplicações complexas, portanto é fundamental conhecer algumas ferramentas  básicas disponibilizadas pela comunicadade de desenvolvedores através de softwares e bibliotecas de código aberto, bem como saber interpretar suas documentações.

Para mais informações acesse [Aula 04: Classes CSharp.](https://cainaantunes.notion.site/Aula-04-Classes-CSharp-245bde521b3b80ea8417d63cdb836d14?source=copy_link) e [Aula 05: Sobrecarga de Métodos e Exceções](https://cainaantunes.notion.site/Aula-05-Sobrecargas-de-m-todos-e-Exce-es-245bde521b3b80d8b8a8e21f472aad85?source=copy_link)

***

1. **Projeto:** Conversor de Temperatura
   
    Você foi contratado para desenvolver uma pequena biblioteca de utilidades que permita a conversão entre diferentes unidades de temperatura.
  
    > Crie uma aplicação Console em C# que permita ao usuário converter temperaturas entre Celsius, Fahrenheit e Kelvin.
    
    O sistema deverá atender aos seguintes requisitos:
    
    1. A classe deve se chamar `TemperatureConverter`.
    2. A classe deve ser estática, pois não faz sentido criar instâncias para ela.
    3. Devem existir métodos para conversão entre todas as principais escalas de temperatura: Celsius (°C), Fahrenheit (°F) e Kelvin (K).
    4. Cada método deverá ser público e estático e receber um valor `double` como parâmetro, retornando também um `double`.
    5. Se atentar à valores abaixo do zero absoluto.
    **Diagrama de Classes:**
    
        ```mermaid
            classDiagram
            class TemperatureConverter {
                <<static>>
                + CelsiusToFahrenheit(celsius : double) : double
                + CelsiusToKelvin(celsius : double) : double
                + FahrenheitToCelsius(fahrenheit : double) : double
                + FahrenheitToKelvin(fahrenheit : double) : double
                + KelvinToCelsius(kelvein : double) : double
                + KelvinToFahrenheit(kelvin : double) : double
            }
        ```
    
    **Fundamentos teóricos:**

    <p align="center">
        <img src="https://static.mundoeducacao.uol.com.br/mundoeducacao/2023/09/escalas-termometricas.jpg" width="400px">
    </p>

 $$
    \frac{C}{5}=\frac{F-32}{9}=\frac{K-273}{5}
 $$
***
2. **Projeto:** Conversor de unidades.
 
    Você está desenvolvendo um programa para auxiliar estudantes de engenharia a converter unidades de medida em cálculos físicos.
    Dependendo da grandeza, a conversão pode receber diferentes tipos de parâmetros:
    * Converter comprimento (milimetros ↔ metros).
    * Converter massa (gramas ↔ kilogramas).
    * Converter tempo (horas:minutos ↔ segundos).
    
    A ação é sempre a mesma: converter unidades, mas os parâmetros recebidos mudam conforme a grandeza.
    **Diagrama de classes:**
    ```mermaid
        classDiagram
        class UnitConverter{
            <<static>>
            +Converter(mm:double): double
            +Converter(g:int): double
            +Converter(h:double, double min): int
        }
    ```
    ***