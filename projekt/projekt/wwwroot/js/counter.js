"use strict";

import { signalR } from "./signalr/dist/browser/signalr";

var connection = new signalR.HubConnectionBuilder().withUrl("/counterHub").build();
connection.on("updateCount", (userCount) => {
    let textMessage = doucument.getElementById("countUsers");
    let count = doucment.createTextNode(userCount);
    textMessage.appendChild(count)
});
connection.start();