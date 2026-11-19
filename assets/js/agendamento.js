
console.log('agendamento.js carregado');

const form = document.querySelector('#form-agendamento');

const cpf = document.querySelector('#cpf');
const avisoCpf = document.querySelector('#aviso-cpf');

const nome = document.querySelector('#nome');
const especialidade = document.querySelector('#especialidade');
const data = document.querySelector('#data');
const horario = document.querySelector('#horario');

const avisoData = document.querySelector('#aviso-data');
const avisoHorario = document.querySelector('#aviso-horario');

const resumo = document.querySelector('#resumo-agendamento');

function validarCpf(campo, aviso) {
    const digitos = campo.value.replace(/\D/g, '');
    const valido = digitos.length === 11;

    aviso.textContent = valido ? '' : 'O CPF precisa ter 11 dígitos.';
    campo.classList.toggle('campo-invalido', !valido);

    return valido;
}

function validarData(campo, aviso) {
    const hoje = new Date();
    hoje.setHours(0, 0, 0, 0);

    const escolhida = new Date(`${campo.value}T00:00:00`);
    const valida = escolhida > hoje;

    aviso.textContent = valida ? '' : 'A consulta precisa ser em uma data futura.';

    return valida;
}

function validarHorario(campo, aviso) {
    const hora = Number(campo.value.split(':')[0]);
    const valida = hora >= 7 && hora < 19;

    aviso.textContent = valida ? '' : 'A Clínica Vida+ atende das 07h às 19h.';

    return valida;
}

form.addEventListener('submit', (event) => {
    event.preventDefault();

    console.log('submit interceptado, a página não recarregou');

    const resultados = [
        validarCpf(cpf, avisoCpf),
        validarData(data, avisoData),
        validarHorario(horario, avisoHorario)
    ];

    if (resultados.includes(false)) return;

    resumo.textContent =
        `${nome.value} agendou ${especialidade.value} em ${data.value} às ${horario.value}.`;

    resumo.classList.remove('oculto');
});
