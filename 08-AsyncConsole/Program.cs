﻿HttpClient client = new();

HttpResponseMessage response =
    await client.GetAsync("https://www.apple.com/");

WriteLine("Apple's home page has {0:N0} bytes.",
    response.Content.Headers.ContentLength);