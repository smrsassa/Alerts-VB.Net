# Alerts-VB.Net
## Como usar?
Para usar os alertas primeiro é necessario importar a pasta Alert para o seu projeto, depois de importar a pasta faça uso do arquivo funcAlert:
```sh
Private alert As New funcAlert
```

Agora é possivel usar essa variavel para chamar os metodos. O unico parametro que eles recebem é a mensagem que vai ser exibida no alerta.
 - success;
  ```sh
  alert.success("success")
  ``` 
 - warning;
 ```sh
  alert.warning("warning")
  ``` 
 - danger.
 ```sh
  alert.danger("danger")
  ``` 
 <br>
Cada um desses metodos abre um alerta diferente
<img src="https://i.imgur.com/GeSIcmd.png"> <img src="https://i.imgur.com/lbvKCGm.png"> <img src="https://i.imgur.com/5YhpZH6.png"><br>

Tambem tem alertas que retornam valores, tipo o alerta "question" que dependendo da resposta do usuario ele retorna um boleano diferente e um alerta que contem um input de texto que vai retornar o que foi digitado no input:
- question;
  ```sh
  If alert.question("Gostou?") Then
    alert.success("Sim")
  Else
    alert.danger("Não")
  End If
  ``` 
- input. 
  ```sh
  Dim resposta = alert.inputText("Qual seu nome?")
  ``` 
<br>
<img src="https://i.imgur.com/8YOkClh.png"> <img src="https://i.imgur.com/WriQuy7.png">
