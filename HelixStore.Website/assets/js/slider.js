const slider = document.querySelector('.slider')
const slider_items = slider.querySelectorAll('.slider__item')

let currentIdx = 0;

const nextIndex = () => {
    if (currentIdx + 1 == 5) {
        currentIdx = 0;
    }
    else {
        currentIdx += 1
    }
}

const initSlider = () => {
    hideAllSliderItem()
    showSliderItem(0);
}

const hideAllSliderItem = () => {
    slider_items.forEach(slide_item => {
        slide_item.style.display = 'none'

    })
}

const hideSliderItem = (idx) => {
    slider_items[idx].style.display = 'none'

}
//
const showSliderItem = (idx) => {
    slider_items[idx].style.display = 'block'

}
initSlider()

setInterval(() => {
    hideSliderItem(currentIdx)
    nextIndex()
    showSliderItem(currentIdx)
}, 10000);
