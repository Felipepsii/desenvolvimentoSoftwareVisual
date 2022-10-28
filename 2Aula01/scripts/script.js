function validaNome(id){
    
    let divNome = document.getElementById(id)
    if(divNome.value.trim().split(' ').length <2)
    {
        divNome.style.border = 'solid 1px red'
        return false
    }
}


function cadastrar(){


    }