// const numero = 10;

// const enumpar = (numero % 2) === 0;

// if (numero === 0) {
//     console.log('O Numero é invalido!')
// } else if (enumpar) {
//     console.log('Par')
// } else {
//     console.log('Impar')
// }

// console.log(enumpar)




// const varGasolina = 5.80;
// const varEtanol = 3.62
// const varkmporlitroGasolina = 12;
// const varkmporlitroEtanol = 8;
// const varDistancia = 600;
// let varConsumoGasolina = 0;
// let varConsumoEtanol = 0;

// varConsumoGasolina = ((varDistancia / varkmporlitroGasolina) * varGasolina)

// varConsumoEtanol = ((varDistancia / varkmporlitroEtanol) * varEtanol)

// console.log('O Valor da Viagem usando Gasolina é: ' + varConsumoGasolina.toFixed(2))
// console.log('O Valor da Viagem usando Etanol é: ' + varConsumoEtanol.toFixed(2))


const varGasolina = 5.80;
const varEtanol = 3.62
const varkmporlitroGasolina = 12;
const varkmporlitroEtanol = 8;
const varDistancia = 600;
const tipocombustivel = 'Etanol'
let varConsumo = 0;

if (tipocombustivel === 'Etanol') {
    varConsumo = ((varDistancia / varkmporlitroEtanol) * varEtanol)
} else {
    varConsumo = ((varDistancia / varkmporlitroGasolina) * varGasolina)
}


console.log('O Valor da Viagem usando ' + tipocombustivel + ' é: ' + varConsumo.toFixed(2))
