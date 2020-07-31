# Alerts-VB.Net
## Como usar?
Para usar os alertas primeiro é necessario importar a pasta Alert para o seu projeto, depois de importar a pasta faça uso do arquivo funcAlert:
```sh
Private alert As New funcAlert
```

Agora é possivel usar essa variavel para chamar a função "showAlert" para usar seus alertas
 ```sh
alert.showAlert("success", "Atualizado com sucesso")
 ```
 O primeiro parametro define o alerta desejado já o segundo define a mensagem que vai acompanhar o alerta, as opções de alertas são:
 - success;
 - warning;
 - danger. <br>
 <img src="https://i.imgur.com/GeSIcmd.png"> <img src="https://i.imgur.com/lbvKCGm.png"> <img src="https://i.imgur.com/5YhpZH6.png"><br>

Tambem tem alertas que retornam um valor, tipo o alerta "question" que dependendo da resposta do usuario ele retorna um boleano diferente e um alerta que contem um input de texto que vai retornar o que foi digitado no input:
- question;
- input. <br>
<img src="https://i.imgur.com/8YOkClh.png"> <img src="https://i.imgur.com/WriQuy7.png">
