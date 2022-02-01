const socket = new WebSocket("ws://localhost:3333/ws");

const btn = document.querySelector('#btn');
const input = document.querySelector('#input');
const textArea = document.querySelector('#textArea');

socket.onopen = function(e) {
    btn.addEventListener('click', () => {
        socket.send(input.value);
        input.value = "";
    });
    socket.onmessage = function (e) {
        textArea.value = e.data;
    }
};




