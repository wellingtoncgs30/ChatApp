let username = document.getElementById("username").value
let password = document.getElementById("password").value
let confirmPassword = document.getElementById("confirm-password").value
const redirectToHome = function() {
    username = ""
    password = ""
    window.location.href = "/Home/Index"
}

const redirectToLogin = function() {
    username = ""
    password = ""
    confirmPassword = ""
    window.location.href = "/Account/Login"
}

//redireciona o usuário no frontend para a tela de login passando a rota em C# do controlador e da ação do mesmo
const redirect = function() {
    window.location.href = "/Account/Logout"
}