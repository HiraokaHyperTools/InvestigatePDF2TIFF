# InvestigatePDF2TIFF

## 実験結果

| tiff<br>bpp | tiff<br>compress  | tiff2pdf | pdf<br>image<br>color | pdf<br>image<br>comp | pdf<br>image<br>bpc | pdf<br>Image<br>interp | pdf<br>image<br>size | pdf<br>image<br>ratio |
|---------|---------------|----------|---------------|--------------|-------------|----------------|--------------|---------------|
| 1       | ADOBE_DEFLATE | -d       | gray          | 1            | 1           | no             | 8336B        | 26%           |
| 1       | ADOBE_DEFLATE | -j       | gray          | 1            | 1           | no             | 8336B        | 26%           |
| 1       | ADOBE_DEFLATE | -n       | gray          | 1            | 1           | no             | 8336B        | 26%           |
| 1       | ADOBE_DEFLATE | -z       | gray          | 1            | 1           | no             | 8336B        | 26%           |
| 1       | ADOBE_DEFLATE |          | gray          | 1            | 1           | no             | 8336B        | 26%           |
| 1       | CCITTFAX3     | -d       | gray          | 1            | 1           | no             | 8285B        | 25%           |
| 1       | CCITTFAX3     | -j       | gray          | 1            | 1           | no             | 8285B        | 25%           |
| 1       | CCITTFAX3     | -n       | gray          | 1            | 1           | no             | 8285B        | 25%           |
| 1       | CCITTFAX3     | -z       | gray          | 1            | 1           | no             | 8285B        | 25%           |
| 1       | CCITTFAX3     |          | gray          | 1            | 1           | no             | 8285B        | 25%           |
| 1       | CCITTFAX4     | -d       | gray          | 1            | 1           | no             | 8287B        | 25%           |
| 1       | CCITTFAX4     | -j       | gray          | 1            | 1           | no             | 8287B        | 25%           |
| 1       | CCITTFAX4     | -n       | gray          | 1            | 1           | no             | 8287B        | 25%           |
| 1       | CCITTFAX4     | -z       | gray          | 1            | 1           | no             | 8287B        | 25%           |
| 1       | CCITTFAX4     |          | gray          | 1            | 1           | no             | 8287B        | 25%           |
| 1       | DEFLATE       | -d       | gray          | 1            | 1           | no             | 8241B        | 25%           |
| 1       | DEFLATE       | -j       | gray          | 1            | 1           | no             | 8241B        | 25%           |
| 1       | DEFLATE       | -n       | gray          | 1            | 1           | no             | 8241B        | 25%           |
| 1       | DEFLATE       | -z       | gray          | 1            | 1           | no             | 8241B        | 25%           |
| 1       | DEFLATE       |          | gray          | 1            | 1           | no             | 8241B        | 25%           |
| 1       | LZW           | -d       | gray          | 1            | 1           | no             | 8199B        | 25%           |
| 1       | LZW           | -j       | gray          | 1            | 1           | no             | 8199B        | 25%           |
| 1       | LZW           | -n       | gray          | 1            | 1           | no             | 8199B        | 25%           |
| 1       | LZW           | -z       | gray          | 1            | 1           | no             | 8199B        | 25%           |
| 1       | LZW           |          | gray          | 1            | 1           | no             | 8199B        | 25%           |
| 1       | PACKBITS      | -d       | gray          | 1            | 1           | no             | 8288B        | 25%           |
| 1       | PACKBITS      | -j       | gray          | 1            | 1           | no             | 8288B        | 25%           |
| 1       | PACKBITS      | -n       | gray          | 1            | 1           | no             | 8288B        | 25%           |
| 1       | PACKBITS      | -z       | gray          | 1            | 1           | no             | 8288B        | 25%           |
| 1       | PACKBITS      |          | gray          | 1            | 1           | no             | 8288B        | 25%           |
| 24      | ADOBE_DEFLATE | -d       | rgb           | 3            | 8           | no             | 763K         | 100%          |
| 24      | ADOBE_DEFLATE | -j       | rgb           | 3            | 8           | no             | 20.6K        | 2.7%          |
| 24      | ADOBE_DEFLATE | -n       | rgb           | 3            | 8           | no             | 763K         | 100%          |
| 24      | ADOBE_DEFLATE | -z       | rgb           | 3            | 8           | no             | 30.9K        | 4.1%          |
| 24      | ADOBE_DEFLATE |          | rgb           | 3            | 8           | no             | 763K         | 100%          |
| 24      | DEFLATE       | -d       | rgb           | 3            | 8           | no             | 763K         | 100%          |
| 24      | DEFLATE       | -j       | rgb           | 3            | 8           | no             | 19.6K        | 2.6%          |
| 24      | DEFLATE       | -n       | rgb           | 3            | 8           | no             | 763K         | 100%          |
| 24      | DEFLATE       | -z       | rgb           | 3            | 8           | no             | 30.6K        | 4.0%          |
| 24      | DEFLATE       |          | rgb           | 3            | 8           | no             | 763K         | 100%          |
| 24      | JPEG          | -d       | rgb           | 3            | 8           | no             | 56.1K        | 7.3%          |
| 24      | JPEG          | -j       | rgb           | 3            | 8           | no             | 56.1K        | 7.3%          |
| 24      | JPEG          | -n       | rgb           | 3            | 8           | no             | 763K         | 100%          |
| 24      | JPEG          | -z       | rgb           | 3            | 8           | no             | 56.1K        | 7.3%          |
| 24      | JPEG          |          | rgb           | 3            | 8           | no             | 56.1K        | 7.3%          |
| 24      | LZW           | -d       | rgb           | 3            | 8           | no             | 763K         | 100%          |
| 24      | LZW           | -j       | rgb           | 3            | 8           | no             | 19.0K        | 2.5%          |
| 24      | LZW           | -n       | rgb           | 3            | 8           | no             | 763K         | 100%          |
| 24      | LZW           | -z       | rgb           | 3            | 8           | no             | 30.6K        | 4.0%          |
| 24      | LZW           |          | rgb           | 3            | 8           | no             | 763K         | 100%          |
| 24      | PACKBITS      | -d       | rgb           | 3            | 8           | no             | 763K         | 100%          |
| 24      | PACKBITS      | -j       | rgb           | 3            | 8           | no             | 19.9K        | 2.6%          |
| 24      | PACKBITS      | -n       | rgb           | 3            | 8           | no             | 763K         | 100%          |
| 24      | PACKBITS      | -z       | rgb           | 3            | 8           | no             | 30.8K        | 4.0%          |
| 24      | PACKBITS      |          | rgb           | 3            | 8           | no             | 763K         | 100%          |
| 32      | ADOBE_DEFLATE | -d       | rgb           | 3            | 8           | no             | 763K         | 100%          |
| 32      | ADOBE_DEFLATE | -j       |               |              |             |                |              |               |
| 32      | ADOBE_DEFLATE | -n       | rgb           | 3            | 8           | no             | 763K         | 100%          |
| 32      | ADOBE_DEFLATE | -z       | rgb           | 3            | 8           | no             | 42.9K        | 5.6%          |
| 32      | ADOBE_DEFLATE |          | rgb           | 3            | 8           | no             | 763K         | 100%          |
| 32      | DEFLATE       | -d       | rgb           | 3            | 8           | no             | 763K         | 100%          |
| 32      | DEFLATE       | -j       |               |              |             |                |              |               |
| 32      | DEFLATE       | -n       | rgb           | 3            | 8           | no             | 763K         | 100%          |
| 32      | DEFLATE       | -z       | rgb           | 3            | 8           | no             | 42.6K        | 5.6%          |
| 32      | DEFLATE       |          | rgb           | 3            | 8           | no             | 763K         | 100%          |
| 32      | LZW           | -d       | rgb           | 3            | 8           | no             | 763K         | 100%          |
| 32      | LZW           | -j       |               |              |             |                |              |               |
| 32      | LZW           | -n       | rgb           | 3            | 8           | no             | 763K         | 100%          |
| 32      | LZW           | -z       | rgb           | 3            | 8           | no             | 42.6K        | 5.6%          |
| 32      | LZW           |          | rgb           | 3            | 8           | no             | 763K         | 100%          |
| 32      | PACKBITS      | -d       | rgb           | 3            | 8           | no             | 763K         | 100%          |
| 32      | PACKBITS      | -j       |               |              |             |                |              |               |
| 32      | PACKBITS      | -n       | rgb           | 3            | 8           | no             | 763K         | 100%          |
| 32      | PACKBITS      | -z       | rgb           | 3            | 8           | no             | 42.8K        | 5.6%          |
| 32      | PACKBITS      |          | rgb           | 3            | 8           | no             | 763K         | 100%          |
| 4       | ADOBE_DEFLATE | -d       | index         | 1            | 4           | no             | 127K         | 100%          |
| 4       | ADOBE_DEFLATE | -j       |               |              |             |                |              |               |
| 4       | ADOBE_DEFLATE | -n       | index         | 1            | 4           | no             | 127K         | 100%          |
| 4       | ADOBE_DEFLATE | -z       | index         | 1            | 4           | no             | 7955B        | 6.1%          |
| 4       | ADOBE_DEFLATE |          | index         | 1            | 4           | no             | 127K         | 100%          |
| 4       | DEFLATE       | -d       | index         | 1            | 4           | no             | 127K         | 100%          |
| 4       | DEFLATE       | -j       |               |              |             |                |              |               |
| 4       | DEFLATE       | -n       | index         | 1            | 4           | no             | 127K         | 100%          |
| 4       | DEFLATE       | -z       | index         | 1            | 4           | no             | 7747B        | 6.0%          |
| 4       | DEFLATE       |          | index         | 1            | 4           | no             | 127K         | 100%          |
| 4       | LZW           | -d       | index         | 1            | 4           | no             | 127K         | 100%          |
| 4       | LZW           | -j       |               |              |             |                |              |               |
| 4       | LZW           | -n       | index         | 1            | 4           | no             | 127K         | 100%          |
| 4       | LZW           | -z       | index         | 1            | 4           | no             | 7669B        | 5.9%          |
| 4       | LZW           |          | index         | 1            | 4           | no             | 127K         | 100%          |
| 4       | PACKBITS      | -d       | index         | 1            | 4           | no             | 127K         | 100%          |
| 4       | PACKBITS      | -j       |               |              |             |                |              |               |
| 4       | PACKBITS      | -n       | index         | 1            | 4           | no             | 127K         | 100%          |
| 4       | PACKBITS      | -z       | index         | 1            | 4           | no             | 7789B        | 6.0%          |
| 4       | PACKBITS      |          | index         | 1            | 4           | no             | 127K         | 100%          |
| 8       | ADOBE_DEFLATE | -d       | index         | 1            | 8           | no             | 254K         | 100%          |
| 8       | ADOBE_DEFLATE | -j       | rgb           | 3            | 8           | no             | 20.5K        | 2.7%          |
| 8       | ADOBE_DEFLATE | -n       | index         | 1            | 8           | no             | 254K         | 100%          |
| 8       | ADOBE_DEFLATE | -z       | index         | 1            | 8           | no             | 10.7K        | 4.2%          |
| 8       | ADOBE_DEFLATE |          | index         | 1            | 8           | no             | 254K         | 100%          |
| 8       | DEFLATE       | -d       | index         | 1            | 8           | no             | 254K         | 100%          |
| 8       | DEFLATE       | -j       | rgb           | 3            | 8           | no             | 19.4K        | 2.5%          |
| 8       | DEFLATE       | -n       | index         | 1            | 8           | no             | 254K         | 100%          |
| 8       | DEFLATE       | -z       | index         | 1            | 8           | no             | 10.5K        | 4.1%          |
| 8       | DEFLATE       |          | index         | 1            | 8           | no             | 254K         | 100%          |
| 8       | LZW           | -d       | index         | 1            | 8           | no             | 254K         | 100%          |
| 8       | LZW           | -j       | rgb           | 3            | 8           | no             | 18.8K        | 2.5%          |
| 8       | LZW           | -n       | index         | 1            | 8           | no             | 254K         | 100%          |
| 8       | LZW           | -z       | index         | 1            | 8           | no             | 10.5K        | 4.1%          |
| 8       | LZW           |          | index         | 1            | 8           | no             | 254K         | 100%          |
| 8       | PACKBITS      | -d       | index         | 1            | 8           | no             | 254K         | 100%          |
| 8       | PACKBITS      | -j       | rgb           | 3            | 8           | no             | 19.7K        | 2.6%          |
| 8       | PACKBITS      | -n       | index         | 1            | 8           | no             | 254K         | 100%          |
| 8       | PACKBITS      | -z       | index         | 1            | 8           | no             | 10.7K        | 4.2%          |
| 8       | PACKBITS      |          | index         | 1            | 8           | no             | 254K         | 100%          |

