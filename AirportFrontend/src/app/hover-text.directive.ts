import { Directive, ElementRef, HostListener } from '@angular/core';

@Directive({
  selector: '[appHoverText]'
})
export class HoverTextDirective {

  constructor(
    public el: ElementRef,
  ) { }

  @HostListener('mouseenter') onMouseEnter() {
    this.highlight( '30px');
  }

  @HostListener('mouseleave') onMouseLeave() {
    this.highlight('');
  }

  private highlight(size: string) {
    this.el.nativeElement.style.fontSize = size;
  }
}
