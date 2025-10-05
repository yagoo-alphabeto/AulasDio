// const nota1 = 5;
// const nota2 = 1;
// const nota3 = 3;
// let media = 0;

// media = ((nota1 + nota2 + nota3) / 3)


// if (media < 5) {
//     console.log('A média foi ' + media + ', então o Aluno foi Reprovado')
// } else if (media > 7) {
//     console.log('A média foi ' + media + ', então o Aluno foi Aprovado')
// } else {
//     console.log('A média foi ' + media + ', então o Aluno foi para a Recuperação')
// }



const peso = 115;
const altura = 1.85;
let IMC = 0;

IMC = (peso / (altura * altura));

if (IMC < 18.5) {
    console.log('O IMC é: ' + IMC + '. Você esta Abaixo do peso')
} else if (IMC >= 18.5 && IMC < 25) {
    console.log('O IMC é: ' + IMC + '. Você esta com o Peso Normal')
} else if (IMC >= 25 && IMC < 30) {
    console.log('O IMC é: ' + IMC + '. Você esta Acima do peso')
} else if (IMC >= 30 && IMC < 40) {
    console.log('O IMC é: ' + IMC + '. Você esta Obeso')
} else {
    console.log('O IMC é: ' + IMC + '. Você esta com Obsidade Grave')
}





