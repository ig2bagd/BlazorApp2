export function showPrompt(message) {
    return prompt(message, "Type Name")
}

export function showAlert(message) {
    return alert(message)
}

export function downloadFile(mimeType, base64String, fileName)
{
    var fileDataUrl = "data:" + mimeType + ";base64," + base64String;
    fetch(fileDataUrl)
        .then(response => response.blob())
        .then(blob => {
            //create a link
            var link = window.document.createElement("a");
            link.href = window.URL.createObjectURL(blob, { type: mimeType });
            link.download = fileName;

            //add, click and remove
            document.body.appendChild(link);
            link.click();
            document.body.remove(link);
        });
}


class Counter {
    constructor() {
        this.currentCount = 0;
    }

    incrementCounter() {
        return ++this.currentCount; 
    }
}

const counter = new Counter();
export { counter }
