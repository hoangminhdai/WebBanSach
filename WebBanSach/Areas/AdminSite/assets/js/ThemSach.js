
const onFileSelected = (event) => {
    var selectedFile = event.target.files[0];
    var reader = new FileReader();

    var imgtag = document.getElementById("displayImg");
    imgtag.title = selectedFile.name;

    reader.onload = function (event) {
        imgtag.src = event.target.result;
    };
    reader.readAsDataURL(selectedFile);
}
const btnCancel = () => {
    document.getElementById('displayImg').src = 'http://placehold.it/400x400';
}

