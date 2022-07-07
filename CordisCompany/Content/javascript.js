
//mapView() function changes the source of the Google map in the Locations page to output a map view between Concord and Rodeo
function mapView() {
    document.getElementById('fMap')
    fMap.src = "https://www.google.com/maps/embed/v1/directions?key=AIzaSyAUjsZnogjOUGhIJbRsEC7XhmPEGup07KI&origin=place_id:ChIJe4ykk7BnhYARVkIEJ1eYELQ&destination=place_id:ChIJVS6ZdlZxhYARVaSbyJrxEN0"

}

//mapView() function changes the source of the Google map in the Locations page to output a street view of Richmond
function streetView() {
    document.getElementById('fMap')
    fMap.src = "https://www.google.com/maps/embed/v1/streetview?location=37.9116%2C-122.3682&key=AIzaSyAUjsZnogjOUGhIJbRsEC7XhmPEGup07KI"

}

function message(counter) {
    sender = document.getElementById("sender"+counter).innerHTML        //Individual info from messages page is output to the message viewer 
    document.getElementById('pSender').innerHTML = sender
    date = document.getElementById("date" + counter).innerHTML
    document.getElementById('pDate').innerHTML = date
    email = document.getElementById("email" + counter).innerHTML

    if (email.includes('[attach]')) {                                   //Messages can have file attachments, which will be shown on the messages page using attachment URL
        attach = email.substring(email.indexOf('[attach]') + 8)
        email = email.substring(0, email.indexOf('[attach]'))

        console.log(attach)
        document.getElementById('attach').src = attach
        document.getElementById('pMessage').innerHTML = email
    }
    else
        document.getElementById('pMessage').innerHTML = email          //Attachment is not output if no attachment is detected

}